namespace Client
{
    partial class DB
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.getAll = new System.Windows.Forms.Button();
            this.get7 = new System.Windows.Forms.Button();
            this.get6 = new System.Windows.Forms.Button();
            this.get5 = new System.Windows.Forms.Button();
            this.get4 = new System.Windows.Forms.Button();
            this.get3 = new System.Windows.Forms.Button();
            this.get2 = new System.Windows.Forms.Button();
            this.get1 = new System.Windows.Forms.Button();
            this.get0 = new System.Windows.Forms.Button();
            this.ch7Box = new System.Windows.Forms.TextBox();
            this.ch6Box = new System.Windows.Forms.TextBox();
            this.ch5Box = new System.Windows.Forms.TextBox();
            this.ch4Box = new System.Windows.Forms.TextBox();
            this.ch3Box = new System.Windows.Forms.TextBox();
            this.ch2Box = new System.Windows.Forms.TextBox();
            this.ch1Box = new System.Windows.Forms.TextBox();
            this.ch0Box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.select = new System.Windows.Forms.Button();
            this.channelListBox = new System.Windows.Forms.CheckedListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.getAll);
            this.panel1.Controls.Add(this.get7);
            this.panel1.Controls.Add(this.get6);
            this.panel1.Controls.Add(this.get5);
            this.panel1.Controls.Add(this.get4);
            this.panel1.Controls.Add(this.get3);
            this.panel1.Controls.Add(this.get2);
            this.panel1.Controls.Add(this.get1);
            this.panel1.Controls.Add(this.get0);
            this.panel1.Controls.Add(this.ch7Box);
            this.panel1.Controls.Add(this.ch6Box);
            this.panel1.Controls.Add(this.ch5Box);
            this.panel1.Controls.Add(this.ch4Box);
            this.panel1.Controls.Add(this.ch3Box);
            this.panel1.Controls.Add(this.ch2Box);
            this.panel1.Controls.Add(this.ch1Box);
            this.panel1.Controls.Add(this.ch0Box);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 582);
            this.panel1.TabIndex = 1;
            // 
            // dateBox
            // 
            this.dateBox.Enabled = false;
            this.dateBox.Location = new System.Drawing.Point(83, 43);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(167, 30);
            this.dateBox.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 77;
            this.label1.Text = "Date:";
            // 
            // getAll
            // 
            this.getAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getAll.Location = new System.Drawing.Point(266, 475);
            this.getAll.Name = "getAll";
            this.getAll.Size = new System.Drawing.Size(102, 30);
            this.getAll.TabIndex = 76;
            this.getAll.Text = "Get All";
            this.getAll.UseVisualStyleBackColor = true;
            this.getAll.Click += new System.EventHandler(this.GetAll_Click);
            // 
            // get7
            // 
            this.get7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.get7.Location = new System.Drawing.Point(266, 428);
            this.get7.Name = "get7";
            this.get7.Size = new System.Drawing.Size(102, 30);
            this.get7.TabIndex = 75;
            this.get7.Text = "Get";
            this.get7.UseVisualStyleBackColor = true;
            this.get7.Click += new System.EventHandler(this.Get7_Click);
            // 
            // get6
            // 
            this.get6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.get6.Location = new System.Drawing.Point(266, 376);
            this.get6.Name = "get6";
            this.get6.Size = new System.Drawing.Size(102, 30);
            this.get6.TabIndex = 74;
            this.get6.Text = "Get";
            this.get6.UseVisualStyleBackColor = true;
            this.get6.Click += new System.EventHandler(this.Get6_Click);
            // 
            // get5
            // 
            this.get5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.get5.Location = new System.Drawing.Point(266, 319);
            this.get5.Name = "get5";
            this.get5.Size = new System.Drawing.Size(102, 30);
            this.get5.TabIndex = 73;
            this.get5.Text = "Get";
            this.get5.UseVisualStyleBackColor = true;
            this.get5.Click += new System.EventHandler(this.Get5_Click);
            // 
            // get4
            // 
            this.get4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.get4.Location = new System.Drawing.Point(266, 269);
            this.get4.Name = "get4";
            this.get4.Size = new System.Drawing.Size(102, 30);
            this.get4.TabIndex = 72;
            this.get4.Text = "Get";
            this.get4.UseVisualStyleBackColor = true;
            this.get4.Click += new System.EventHandler(this.Get4_Click);
            // 
            // get3
            // 
            this.get3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.get3.Location = new System.Drawing.Point(266, 225);
            this.get3.Name = "get3";
            this.get3.Size = new System.Drawing.Size(102, 30);
            this.get3.TabIndex = 71;
            this.get3.Text = "Get";
            this.get3.UseVisualStyleBackColor = true;
            this.get3.Click += new System.EventHandler(this.Get3_Click);
            // 
            // get2
            // 
            this.get2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.get2.Location = new System.Drawing.Point(266, 182);
            this.get2.Name = "get2";
            this.get2.Size = new System.Drawing.Size(102, 30);
            this.get2.TabIndex = 70;
            this.get2.Text = "Get";
            this.get2.UseVisualStyleBackColor = true;
            this.get2.Click += new System.EventHandler(this.Get2_Click);
            // 
            // get1
            // 
            this.get1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.get1.Location = new System.Drawing.Point(266, 135);
            this.get1.Name = "get1";
            this.get1.Size = new System.Drawing.Size(102, 30);
            this.get1.TabIndex = 69;
            this.get1.Text = "Get";
            this.get1.UseVisualStyleBackColor = true;
            this.get1.Click += new System.EventHandler(this.Get1_Click);
            // 
            // get0
            // 
            this.get0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.get0.Location = new System.Drawing.Point(266, 86);
            this.get0.Name = "get0";
            this.get0.Size = new System.Drawing.Size(102, 30);
            this.get0.TabIndex = 68;
            this.get0.Text = "Get";
            this.get0.UseVisualStyleBackColor = true;
            this.get0.Click += new System.EventHandler(this.Get0_Click);
            // 
            // ch7Box
            // 
            this.ch7Box.Enabled = false;
            this.ch7Box.Location = new System.Drawing.Point(83, 428);
            this.ch7Box.Name = "ch7Box";
            this.ch7Box.Size = new System.Drawing.Size(167, 30);
            this.ch7Box.TabIndex = 67;
            // 
            // ch6Box
            // 
            this.ch6Box.Enabled = false;
            this.ch6Box.Location = new System.Drawing.Point(83, 376);
            this.ch6Box.Name = "ch6Box";
            this.ch6Box.Size = new System.Drawing.Size(167, 30);
            this.ch6Box.TabIndex = 66;
            // 
            // ch5Box
            // 
            this.ch5Box.Enabled = false;
            this.ch5Box.Location = new System.Drawing.Point(83, 319);
            this.ch5Box.Name = "ch5Box";
            this.ch5Box.Size = new System.Drawing.Size(167, 30);
            this.ch5Box.TabIndex = 65;
            // 
            // ch4Box
            // 
            this.ch4Box.Enabled = false;
            this.ch4Box.Location = new System.Drawing.Point(83, 269);
            this.ch4Box.Name = "ch4Box";
            this.ch4Box.Size = new System.Drawing.Size(167, 30);
            this.ch4Box.TabIndex = 64;
            // 
            // ch3Box
            // 
            this.ch3Box.Enabled = false;
            this.ch3Box.Location = new System.Drawing.Point(83, 225);
            this.ch3Box.Name = "ch3Box";
            this.ch3Box.Size = new System.Drawing.Size(167, 30);
            this.ch3Box.TabIndex = 63;
            // 
            // ch2Box
            // 
            this.ch2Box.Enabled = false;
            this.ch2Box.Location = new System.Drawing.Point(83, 182);
            this.ch2Box.Name = "ch2Box";
            this.ch2Box.Size = new System.Drawing.Size(167, 30);
            this.ch2Box.TabIndex = 62;
            // 
            // ch1Box
            // 
            this.ch1Box.Enabled = false;
            this.ch1Box.Location = new System.Drawing.Point(83, 135);
            this.ch1Box.Name = "ch1Box";
            this.ch1Box.Size = new System.Drawing.Size(167, 30);
            this.ch1Box.TabIndex = 61;
            // 
            // ch0Box
            // 
            this.ch0Box.Enabled = false;
            this.ch0Box.Location = new System.Drawing.Point(83, 86);
            this.ch0Box.Name = "ch0Box";
            this.ch0Box.Size = new System.Drawing.Size(167, 30);
            this.ch0Box.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 431);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 25);
            this.label9.TabIndex = 59;
            this.label9.Text = "Ch7:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 25);
            this.label8.TabIndex = 58;
            this.label8.Text = "Ch6:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 25);
            this.label7.TabIndex = 57;
            this.label7.Text = "Ch5:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 25);
            this.label6.TabIndex = 56;
            this.label6.Text = "Ch4:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 55;
            this.label5.Text = "Ch3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 54;
            this.label4.Text = "Ch2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 53;
            this.label3.Text = "Ch1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 52;
            this.label2.Text = "Ch0:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.select);
            this.panel2.Controls.Add(this.channelListBox);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.dateTimePickerTo);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.dateTimePickerFrom);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(377, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 126);
            this.panel2.TabIndex = 2;
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(688, 38);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(102, 30);
            this.select.TabIndex = 61;
            this.select.Text = "Select";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.Select_Click);
            // 
            // channelListBox
            // 
            this.channelListBox.FormattingEnabled = true;
            this.channelListBox.Items.AddRange(new object[] {
            "Ch0",
            "Ch1",
            "Ch2",
            "Ch3",
            "Ch4",
            "Ch5",
            "Ch6",
            "Ch7"});
            this.channelListBox.Location = new System.Drawing.Point(77, 39);
            this.channelListBox.Name = "channelListBox";
            this.channelListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.channelListBox.Size = new System.Drawing.Size(98, 79);
            this.channelListBox.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(438, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 25);
            this.label13.TabIndex = 60;
            this.label13.Text = "To";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(480, 39);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 30);
            this.dateTimePickerTo.TabIndex = 59;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(169, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 25);
            this.label12.TabIndex = 58;
            this.label12.Text = "From";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 25);
            this.label11.TabIndex = 57;
            this.label11.Text = "Ch:";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(232, 39);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 30);
            this.dateTimePickerFrom.TabIndex = 56;
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
            this.chart1.Location = new System.Drawing.Point(377, 126);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(802, 456);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // DB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 582);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DB";
            this.Text = "DB";
            this.Load += new System.EventHandler(this.DB_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getAll;
        private System.Windows.Forms.Button get7;
        private System.Windows.Forms.Button get6;
        private System.Windows.Forms.Button get5;
        private System.Windows.Forms.Button get4;
        private System.Windows.Forms.Button get3;
        private System.Windows.Forms.Button get2;
        private System.Windows.Forms.Button get1;
        private System.Windows.Forms.Button get0;
        private System.Windows.Forms.TextBox ch7Box;
        private System.Windows.Forms.TextBox ch6Box;
        private System.Windows.Forms.TextBox ch5Box;
        private System.Windows.Forms.TextBox ch4Box;
        private System.Windows.Forms.TextBox ch3Box;
        private System.Windows.Forms.TextBox ch2Box;
        private System.Windows.Forms.TextBox ch1Box;
        private System.Windows.Forms.TextBox ch0Box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.CheckedListBox channelListBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}