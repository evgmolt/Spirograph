using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spiro
{
    public partial class Form1 : Form, IMessageHandler
    {
        BufferedPanel BufPanel;
        ByteDecomposer Decomposer;
        DataArrays DataA;
        StreamWriter TextWriter;
        CurvesPainter Painter;
        USBserialPort USBPort;
        double ScaleY = 1;

        public event Action<Message> WindowsMessage;
        public Form1()
        {
            InitializeComponent();
            BufPanel = new BufferedPanel(0);
            panelGraph.Controls.Add(BufPanel);
            BufPanel.Dock = DockStyle.Fill;
            BufPanel.Paint += bufferedPanel_Paint;
            DataA = new DataArrays(ByteDecomposer.DataArrSize);
            Decomposer = new ByteDecomposerADS1115(DataA);
            Decomposer.OnDecomposePacketEvent += OnPacketReceived;
            Painter = new CurvesPainter(BufPanel, Decomposer);
            USBPort = new USBserialPort(this, Decomposer.BaudRate);
//            USBPort.ConnectionOk += OnConnectionOk;
            USBPort.Connect();
        }


        protected override void WndProc(ref Message m)
        {
            const int WM_DEVICECHANGE = 0x0219;
            if (WindowsMessage != null)
            {
                if (m.Msg == WM_DEVICECHANGE)
                {
                    WindowsMessage(m);
                }
            }
            base.WndProc(ref m);
        }

        private void bufferedPanel_Paint(object sender, PaintEventArgs e)
        {
            if (DataA == null)
            {
                return;
            }
            var ArrayList = new List<double[]>();
            ArrayList.Add(DataA.RealTimeArray);
            bool ViewMode = false;
            int ViewShift = 0;
            int MaxValue = 200;
            Painter.Paint(ViewMode, ViewShift, ArrayList, null, ScaleY, MaxValue, e);
        }

        private void OnPacketReceived(object sender, PacketEventArgs e)
        {
            uint currentIndex = (e.MainIndex - 1) & (ByteDecomposer.DataArrSize - 1);
            double CurrentPressure = e.RealTimeValue;
            if (Decomposer.RecordStarted)
            {
                labRecordSize.Text = "Record size : " + e.PacketCounter / Decomposer.SamplingFrequency;
            }
            label1.Text = e.PacketCounter.ToString();
        }

        private void timerRead_Tick(object sender, EventArgs e)
        {
            if (USBPort?.PortHandle?.IsOpen == true)
            {
                Decomposer?.Decompos(USBPort, TextWriter);
            }
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            if (USBPort == null)
            {
                labPort.Text = "Disconnected";
                return;
            }
            if (USBPort.PortHandle == null)
            {
                labPort.Text = "Disconnected";
                return;
            }
            if (USBPort.PortHandle.IsOpen)
            {
                labPort.Text = "Connected to " + USBPort.PortNames[USBPort.CurrentPort];
            }
            else
            {
                labPort.Text = "Disconnected";
            }
        }

        private void timerPaint_Tick(object sender, EventArgs e)
        {
            BufPanel.Refresh();

        }

        private void butStartRecord_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextWriter = new StreamWriter(saveFileDialog1.FileName);
                Decomposer.RecordStarted = true;
            }
        }

        private void butStopRecord_Click(object sender, EventArgs e)
        {
            TextWriter.Close();
            TextWriter.Dispose();
            Decomposer.RecordStarted = false;
        }

        private void trackBarAmp_ValueChanged(object sender, EventArgs e)
        {
            double a = trackBarAmp.Value;
            ScaleY = Math.Pow(2, a / 2);
            BufPanel.Refresh();
        }
    }
}
