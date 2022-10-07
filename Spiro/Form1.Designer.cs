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
            this.SuspendLayout();
            // 
            // panelGraph
            // 
            this.panelGraph.Location = new System.Drawing.Point(178, 12);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(586, 537);
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
            this.labPort.Location = new System.Drawing.Point(26, 406);
            this.labPort.Name = "labPort";
            this.labPort.Size = new System.Drawing.Size(35, 13);
            this.labPort.TabIndex = 1;
            this.labPort.Text = "label1";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.labPort);
            this.Controls.Add(this.panelGraph);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGraph;
        private System.Windows.Forms.Timer timerRead;
        private System.Windows.Forms.Label labPort;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.Timer timerPaint;
    }
}

