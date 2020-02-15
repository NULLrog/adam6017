namespace Client
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.get0 = new System.Windows.Forms.Button();
            this.get1 = new System.Windows.Forms.Button();
            this.get2 = new System.Windows.Forms.Button();
            this.get3 = new System.Windows.Forms.Button();
            this.get4 = new System.Windows.Forms.Button();
            this.get5 = new System.Windows.Forms.Button();
            this.get6 = new System.Windows.Forms.Button();
            this.get7 = new System.Windows.Forms.Button();
            this.disconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Culture = new System.Globalization.CultureInfo("en-001");
            this.maskedTextBox1.Location = new System.Drawing.Point(83, 14);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(148, 30);
            this.maskedTextBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP:";
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(252, 14);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(102, 30);
            this.connect.TabIndex = 2;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ch0:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ch1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ch2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ch3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ch4:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ch5:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ch6:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Ch7:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(83, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 30);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(83, 146);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 30);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(83, 193);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 30);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(83, 236);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(148, 30);
            this.textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(83, 280);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(148, 30);
            this.textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(83, 330);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(148, 30);
            this.textBox6.TabIndex = 16;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(83, 387);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(148, 30);
            this.textBox7.TabIndex = 17;
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(83, 439);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(148, 30);
            this.textBox8.TabIndex = 18;
            // 
            // get0
            // 
            this.get0.Location = new System.Drawing.Point(252, 97);
            this.get0.Name = "get0";
            this.get0.Size = new System.Drawing.Size(102, 30);
            this.get0.TabIndex = 19;
            this.get0.Text = "Get";
            this.get0.UseVisualStyleBackColor = true;
            this.get0.Click += new System.EventHandler(this.Get0_Click);
            // 
            // get1
            // 
            this.get1.Location = new System.Drawing.Point(252, 146);
            this.get1.Name = "get1";
            this.get1.Size = new System.Drawing.Size(102, 30);
            this.get1.TabIndex = 20;
            this.get1.Text = "Get";
            this.get1.UseVisualStyleBackColor = true;
            this.get1.Click += new System.EventHandler(this.Get1_Click);
            // 
            // get2
            // 
            this.get2.Location = new System.Drawing.Point(252, 193);
            this.get2.Name = "get2";
            this.get2.Size = new System.Drawing.Size(102, 30);
            this.get2.TabIndex = 21;
            this.get2.Text = "Get";
            this.get2.UseVisualStyleBackColor = true;
            this.get2.Click += new System.EventHandler(this.Get2_Click);
            // 
            // get3
            // 
            this.get3.Location = new System.Drawing.Point(252, 236);
            this.get3.Name = "get3";
            this.get3.Size = new System.Drawing.Size(102, 30);
            this.get3.TabIndex = 22;
            this.get3.Text = "Get";
            this.get3.UseVisualStyleBackColor = true;
            this.get3.Click += new System.EventHandler(this.Get3_Click);
            // 
            // get4
            // 
            this.get4.Location = new System.Drawing.Point(252, 280);
            this.get4.Name = "get4";
            this.get4.Size = new System.Drawing.Size(102, 30);
            this.get4.TabIndex = 23;
            this.get4.Text = "Get";
            this.get4.UseVisualStyleBackColor = true;
            this.get4.Click += new System.EventHandler(this.Get4_Click);
            // 
            // get5
            // 
            this.get5.Location = new System.Drawing.Point(252, 330);
            this.get5.Name = "get5";
            this.get5.Size = new System.Drawing.Size(102, 30);
            this.get5.TabIndex = 24;
            this.get5.Text = "Get";
            this.get5.UseVisualStyleBackColor = true;
            this.get5.Click += new System.EventHandler(this.Get5_Click);
            // 
            // get6
            // 
            this.get6.Location = new System.Drawing.Point(252, 387);
            this.get6.Name = "get6";
            this.get6.Size = new System.Drawing.Size(102, 30);
            this.get6.TabIndex = 25;
            this.get6.Text = "Get";
            this.get6.UseVisualStyleBackColor = true;
            this.get6.Click += new System.EventHandler(this.Get6_Click);
            // 
            // get7
            // 
            this.get7.Location = new System.Drawing.Point(252, 439);
            this.get7.Name = "get7";
            this.get7.Size = new System.Drawing.Size(102, 30);
            this.get7.TabIndex = 26;
            this.get7.Text = "Get";
            this.get7.UseVisualStyleBackColor = true;
            this.get7.Click += new System.EventHandler(this.Get7_Click);
            // 
            // disconnect
            // 
            this.disconnect.Location = new System.Drawing.Point(252, 50);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(102, 30);
            this.disconnect.TabIndex = 27;
            this.disconnect.Text = "Disconnect";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 512);
            this.Controls.Add(this.disconnect);
            this.Controls.Add(this.get7);
            this.Controls.Add(this.get6);
            this.Controls.Add(this.get5);
            this.Controls.Add(this.get4);
            this.Controls.Add(this.get3);
            this.Controls.Add(this.get2);
            this.Controls.Add(this.get1);
            this.Controls.Add(this.get0);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button get0;
        private System.Windows.Forms.Button get1;
        private System.Windows.Forms.Button get2;
        private System.Windows.Forms.Button get3;
        private System.Windows.Forms.Button get4;
        private System.Windows.Forms.Button get5;
        private System.Windows.Forms.Button get6;
        private System.Windows.Forms.Button get7;
        private System.Windows.Forms.Button disconnect;
    }
}

