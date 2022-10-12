namespace Spiro
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelGraph = new System.Windows.Forms.Panel();
            this.timerRead = new System.Windows.Forms.Timer(this.components);
            this.labPort = new System.Windows.Forms.Label();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.timerPaint = new System.Windows.Forms.Timer(this.components);
            this.butStartRecord = new System.Windows.Forms.Button();
            this.butStopRecord = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.labRecordSize = new System.Windows.Forms.Label();
            this.labPacketCounter = new System.Windows.Forms.Label();
            this.trackBarAmp = new System.Windows.Forms.TrackBar();
            this.labValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmp)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGraph
            // 
            this.panelGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraph.Location = new System.Drawing.Point(235, 3);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(635, 351);
            this.panelGraph.TabIndex = 0;
            // 
            // timerRead
            // 
            this.timerRead.Enabled = true;
            this.timerRead.Tick += new System.EventHandler(this.timerRead_Tick);
            // 
            // labPort
            // 
            this.labPort.AutoSize = true;
            this.labPort.Location = new System.Drawing.Point(9, 9);
            this.labPort.Name = "labPort";
            this.labPort.Size = new System.Drawing.Size(73, 13);
            this.labPort.TabIndex = 1;
            this.labPort.Text = "Disconnected";
            // 
            // timerStatus
            // 
            this.timerStatus.Enabled = true;
            this.timerStatus.Interval = 200;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // timerPaint
            // 
            this.timerPaint.Enabled = true;
            this.timerPaint.Tick += new System.EventHandler(this.timerPaint_Tick);
            // 
            // butStartRecord
            // 
            this.butStartRecord.Location = new System.Drawing.Point(16, 16);
            this.butStartRecord.Name = "butStartRecord";
            this.butStartRecord.Size = new System.Drawing.Size(75, 23);
            this.butStartRecord.TabIndex = 2;
            this.butStartRecord.Text = "Start record";
            this.butStartRecord.UseVisualStyleBackColor = true;
            this.butStartRecord.Click += new System.EventHandler(this.butStartRecord_Click);
            // 
            // butStopRecord
            // 
            this.butStopRecord.Location = new System.Drawing.Point(16, 117);
            this.butStopRecord.Name = "butStopRecord";
            this.butStopRecord.Size = new System.Drawing.Size(75, 23);
            this.butStopRecord.TabIndex = 3;
            this.butStopRecord.Text = "Stop record";
            this.butStopRecord.UseVisualStyleBackColor = true;
            this.butStopRecord.Click += new System.EventHandler(this.butStopRecord_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // labRecordSize
            // 
            this.labRecordSize.AutoSize = true;
            this.labRecordSize.Location = new System.Drawing.Point(13, 54);
            this.labRecordSize.Name = "labRecordSize";
            this.labRecordSize.Size = new System.Drawing.Size(72, 13);
            this.labRecordSize.TabIndex = 4;
            this.labRecordSize.Text = "Record size : ";
            // 
            // labPacketCounter
            // 
            this.labPacketCounter.AutoSize = true;
            this.labPacketCounter.Location = new System.Drawing.Point(13, 156);
            this.labPacketCounter.Name = "labPacketCounter";
            this.labPacketCounter.Size = new System.Drawing.Size(78, 13);
            this.labPacketCounter.TabIndex = 5;
            this.labPacketCounter.Text = "PacketCounter";
            // 
            // trackBarAmp
            // 
            this.trackBarAmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarAmp.Location = new System.Drawing.Point(876, 3);
            this.trackBarAmp.Minimum = -10;
            this.trackBarAmp.Name = "trackBarAmp";
            this.trackBarAmp.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarAmp.Size = new System.Drawing.Size(39, 351);
            this.trackBarAmp.TabIndex = 1;
            this.trackBarAmp.ValueChanged += new System.EventHandler(this.trackBarAmp_ValueChanged);
            // 
            // labValue
            // 
            this.labValue.AutoSize = true;
            this.labValue.Location = new System.Drawing.Point(13, 184);
            this.labValue.Name = "labValue";
            this.labValue.Size = new System.Drawing.Size(34, 13);
            this.labValue.TabIndex = 7;
            this.labValue.Text = "Value";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.60819F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.39182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Controls.Add(this.panelGraph, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.trackBarAmp, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.80597F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.19403F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(918, 402);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.butStartRecord);
            this.panel1.Controls.Add(this.labValue);
            this.panel1.Controls.Add(this.butStopRecord);
            this.panel1.Controls.Add(this.labPacketCounter);
            this.panel1.Controls.Add(this.labRecordSize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 351);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labPort);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 360);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 39);
            this.panel2.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 81);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(189, 14);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 402);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Spirograph";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmp)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGraph;
        private System.Windows.Forms.Timer timerRead;
        private System.Windows.Forms.Label labPort;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.Timer timerPaint;
        private System.Windows.Forms.Button butStartRecord;
        private System.Windows.Forms.Button butStopRecord;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label labRecordSize;
        private System.Windows.Forms.Label labPacketCounter;
        private System.Windows.Forms.TrackBar trackBarAmp;
        private System.Windows.Forms.Label labValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

