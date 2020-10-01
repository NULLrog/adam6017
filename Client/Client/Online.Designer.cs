namespace Client
{
    partial class Online
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.start = new System.Windows.Forms.Button();
            this.channelsBox = new System.Windows.Forms.GroupBox();
            this.ch7 = new System.Windows.Forms.RadioButton();
            this.ch6 = new System.Windows.Forms.RadioButton();
            this.ch5 = new System.Windows.Forms.RadioButton();
            this.ch4 = new System.Windows.Forms.RadioButton();
            this.ch3 = new System.Windows.Forms.RadioButton();
            this.ch1 = new System.Windows.Forms.RadioButton();
            this.ch2 = new System.Windows.Forms.RadioButton();
            this.ch0 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.channelsBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start.Location = new System.Drawing.Point(699, 53);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(102, 30);
            this.start.TabIndex = 78;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // channelsBox
            // 
            this.channelsBox.Controls.Add(this.ch7);
            this.channelsBox.Controls.Add(this.ch6);
            this.channelsBox.Controls.Add(this.ch5);
            this.channelsBox.Controls.Add(this.ch4);
            this.channelsBox.Controls.Add(this.ch3);
            this.channelsBox.Controls.Add(this.ch1);
            this.channelsBox.Controls.Add(this.ch2);
            this.channelsBox.Controls.Add(this.ch0);
            this.channelsBox.Location = new System.Drawing.Point(12, 12);
            this.channelsBox.Name = "channelsBox";
            this.channelsBox.Size = new System.Drawing.Size(681, 71);
            this.channelsBox.TabIndex = 79;
            this.channelsBox.TabStop = false;
            this.channelsBox.Text = "Chanel:";
            // 
            // ch7
            // 
            this.ch7.AutoSize = true;
            this.ch7.Location = new System.Drawing.Point(587, 36);
            this.ch7.Name = "ch7";
            this.ch7.Size = new System.Drawing.Size(77, 29);
            this.ch7.TabIndex = 14;
            this.ch7.TabStop = true;
            this.ch7.Text = "Ch-7";
            this.ch7.UseVisualStyleBackColor = true;
            // 
            // ch6
            // 
            this.ch6.AutoSize = true;
            this.ch6.Location = new System.Drawing.Point(504, 36);
            this.ch6.Name = "ch6";
            this.ch6.Size = new System.Drawing.Size(77, 29);
            this.ch6.TabIndex = 13;
            this.ch6.TabStop = true;
            this.ch6.Text = "Ch-6";
            this.ch6.UseVisualStyleBackColor = true;
            // 
            // ch5
            // 
            this.ch5.AutoSize = true;
            this.ch5.Location = new System.Drawing.Point(421, 36);
            this.ch5.Name = "ch5";
            this.ch5.Size = new System.Drawing.Size(77, 29);
            this.ch5.TabIndex = 12;
            this.ch5.TabStop = true;
            this.ch5.Text = "Ch-5";
            this.ch5.UseVisualStyleBackColor = true;
            // 
            // ch4
            // 
            this.ch4.AutoSize = true;
            this.ch4.Location = new System.Drawing.Point(338, 36);
            this.ch4.Name = "ch4";
            this.ch4.Size = new System.Drawing.Size(77, 29);
            this.ch4.TabIndex = 11;
            this.ch4.TabStop = true;
            this.ch4.Text = "Ch-4";
            this.ch4.UseVisualStyleBackColor = true;
            // 
            // ch3
            // 
            this.ch3.AutoSize = true;
            this.ch3.Location = new System.Drawing.Point(255, 36);
            this.ch3.Name = "ch3";
            this.ch3.Size = new System.Drawing.Size(77, 29);
            this.ch3.TabIndex = 10;
            this.ch3.TabStop = true;
            this.ch3.Text = "Ch-3";
            this.ch3.UseVisualStyleBackColor = true;
            // 
            // ch1
            // 
            this.ch1.AutoSize = true;
            this.ch1.Location = new System.Drawing.Point(89, 36);
            this.ch1.Name = "ch1";
            this.ch1.Size = new System.Drawing.Size(77, 29);
            this.ch1.TabIndex = 9;
            this.ch1.TabStop = true;
            this.ch1.Text = "Ch-1";
            this.ch1.UseVisualStyleBackColor = true;
            // 
            // ch2
            // 
            this.ch2.AutoSize = true;
            this.ch2.Location = new System.Drawing.Point(172, 36);
            this.ch2.Name = "ch2";
            this.ch2.Size = new System.Drawing.Size(77, 29);
            this.ch2.TabIndex = 9;
            this.ch2.TabStop = true;
            this.ch2.Text = "Ch-2";
            this.ch2.UseVisualStyleBackColor = true;
            // 
            // ch0
            // 
            this.ch0.AutoSize = true;
            this.ch0.Checked = true;
            this.ch0.Location = new System.Drawing.Point(6, 36);
            this.ch0.Name = "ch0";
            this.ch0.Size = new System.Drawing.Size(77, 29);
            this.ch0.TabIndex = 8;
            this.ch0.TabStop = true;
            this.ch0.Text = "Ch-0";
            this.ch0.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.stop);
            this.panel1.Controls.Add(this.channelsBox);
            this.panel1.Controls.Add(this.start);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1183, 100);
            this.panel1.TabIndex = 80;
            // 
            // stop
            // 
            this.stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stop.Location = new System.Drawing.Point(807, 53);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(102, 30);
            this.stop.TabIndex = 80;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Control;
            this.chart1.BorderlineColor = System.Drawing.SystemColors.Control;
            this.chart1.BorderSkin.PageColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 12;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.LabelAutoFitMaxFontSize = 12;
            chartArea1.AxisY.Maximum = 12D;
            chartArea1.AxisY.Minimum = -12D;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.CursorX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea1.CursorY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.SystemColors.Control;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.IsTextAutoFit = false;
            legend1.ItemColumnSpacing = 30;
            legend1.MaximumAutoSize = 40F;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 100);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(1183, 514);
            this.chart1.TabIndex = 81;
            this.chart1.Text = "chart1";
            // 
            // Online
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 614);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Online";
            this.Text = "Online";
            this.Load += new System.EventHandler(this.Online_Load);
            this.channelsBox.ResumeLayout(false);
            this.channelsBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.GroupBox channelsBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton ch7;
        private System.Windows.Forms.RadioButton ch6;
        private System.Windows.Forms.RadioButton ch5;
        private System.Windows.Forms.RadioButton ch4;
        private System.Windows.Forms.RadioButton ch3;
        private System.Windows.Forms.RadioButton ch1;
        private System.Windows.Forms.RadioButton ch2;
        private System.Windows.Forms.RadioButton ch0;
    }
}