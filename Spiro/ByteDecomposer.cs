using System;
using System.IO;
using System.Windows.Forms;

namespace Spiro
{
    internal class ByteDecomposer
    {
        public const int SamplingFrequency = 250;
        public const int BaudRate = 115200;
        public const int BytesInPacket = 3;
        public const int DataArrSize = 0x10000;

        private int _zeroLine = 0;

        public int ZeroLine 
        { 
            get { return _zeroLine; } 
            set { _zeroLine = value; }
        }

        protected const byte marker1 = 0x19; 

        protected DataArrays Data;

        public event EventHandler<PacketEventArgs> OnDecomposePacketEvent;

        public uint MainIndex = 0;
        public int PacketCounter = 0;

        public bool RecordStarted;

        protected int tmpValue;

        protected int byteNum;

        public ByteDecomposer(DataArrays data)
        {
            Data = data;
            RecordStarted = false;
            MainIndex = 0;
            byteNum = 0;
//            _zeroLine = 952;
        }

        protected virtual void OnDecomposeLineEvent()
        {
            OnDecomposePacketEvent?.Invoke(
                this,
                new PacketEventArgs
                {
                    RealTimeValue = Data.RealTimeArray[MainIndex],
                    PacketCounter = PacketCounter,
                    MainIndex = MainIndex
                });
        }

        public int Decompos(USBserialPort usbport, StreamWriter saveFileStream)
        {
            return Decompos(usbport, null, saveFileStream);
        }

        //Возвращает число прочитанных и обработанных байт
        public int Decompos(USBserialPort usbport, Stream saveFileStream, StreamWriter txtFileStream)
        {
            int bytes = usbport.BytesRead;
            if (bytes == 0)
            {
                return 0;
            }
            if (saveFileStream != null && RecordStarted)
            {
                try
                {
                    saveFileStream.Write(usbport.PortBuf, 0, bytes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Save file stream error" + ex.Message);
                }
            }
            for (int i = 0; i < bytes; i++)
            {
                switch (byteNum)
                {
                    case 0:// Marker
                        if (usbport.PortBuf[i] == marker1)
                        {
                            byteNum = 1;
                        }
                        break;
                    case 1:
                        tmpValue = usbport.PortBuf[i];
                        byteNum = 2;
                        break;
                    case 2:
                        tmpValue += 0x100 * usbport.PortBuf[i];
                        if ((tmpValue & 0x8000) != 0)
                        {
                            tmpValue -= 0x10000;
                        }

                        Data.RealTimeArray[MainIndex] = tmpValue - _zeroLine;

                        byteNum = 0;

                        if (RecordStarted)
                        {
                            txtFileStream.WriteLine(Data.GetDataString(MainIndex));
                        }
                        OnDecomposeLineEvent();
                        PacketCounter++;
                        MainIndex++;
                        MainIndex &= DataArrSize - 1;
                        break;
                }
            }
            usbport.BytesRead = 0;
            return bytes;
        }
    }
}
