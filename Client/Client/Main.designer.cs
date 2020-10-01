namespace Client
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.online = new System.Windows.Forms.Button();
            this.db = new System.Windows.Forms.Button();
            this.lastVal = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Teal;
            this.panelMenu.Controls.Add(this.online);
            this.panelMenu.Controls.Add(this.db);
            this.panelMenu.Controls.Add(this.lastVal);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(181, 753);
            this.panelMenu.TabIndex = 0;
            // 
            // online
            // 
            this.online.Cursor = System.Windows.Forms.Cursors.Hand;
            this.online.Dock = System.Windows.Forms.DockStyle.Top;
            this.online.FlatAppearance.BorderSize = 0;
            this.online.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.online.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.online.ForeColor = System.Drawing.Color.Transparent;
            this.online.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.online.Location = new System.Drawing.Point(0, 292);
            this.online.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.online.Name = "online";
            this.online.Size = new System.Drawing.Size(181, 100);
            this.online.TabIndex = 3;
            this.online.Text = "˃ Online";
            this.online.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.online.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.online.UseVisualStyleBackColor = true;
            this.online.Click += new System.EventHandler(this.Online_Click);
            // 
            // db
            // 
            this.db.Cursor = System.Windows.Forms.Cursors.Hand;
            this.db.Dock = System.Windows.Forms.DockStyle.Top;
            this.db.FlatAppearance.BorderSize = 0;
            this.db.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.db.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.db.ForeColor = System.Drawing.Color.Transparent;
            this.db.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.db.Location = new System.Drawing.Point(0, 192);
            this.db.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.db.Name = "db";
            this.db.Size = new System.Drawing.Size(181, 100);
            this.db.TabIndex = 2;
            this.db.Text = "˃ Database";
            this.db.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.db.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.db.UseVisualStyleBackColor = true;
            this.db.Click += new System.EventHandler(this.Db_Click);
            // 
            // lastVal
            // 
            this.lastVal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lastVal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lastVal.FlatAppearance.BorderSize = 0;
            this.lastVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lastVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastVal.ForeColor = System.Drawing.Color.Transparent;
            this.lastVal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lastVal.Location = new System.Drawing.Point(0, 92);
            this.lastVal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastVal.Name = "lastVal";
            this.lastVal.Size = new System.Drawing.Size(181, 100);
            this.lastVal.TabIndex = 1;
            this.lastVal.Text = "˃ Last value";
            this.lastVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lastVal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lastVal.UseVisualStyleBackColor = true;
            this.lastVal.Click += new System.EventHandler(this.LastVal_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(181, 92);
            this.panelLogo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(181, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 92);
            this.panel1.TabIndex = 1;
            // 
            // header
            // 
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.header.ForeColor = System.Drawing.SystemColors.Control;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1201, 92);
            this.header.TabIndex = 3;
            this.header.Text = "Welcom!";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(181, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1201, 661);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1201, 455);
            this.label1.TabIndex = 84;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADAM-6017";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button lastVal;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button online;
        private System.Windows.Forms.Button db;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}

