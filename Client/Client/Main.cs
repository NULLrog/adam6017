using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace Client
{

    public partial class Main : Form
    {
        public static NetworkStream stream;
        public byte[] data;
        public string message;
        public static string ip;
        private Form activeForm;
        public Main()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (header.Text == childForm.Text)
                return;
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(childForm);
            this.panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            header.Text = childForm.Text;
        }


        private void LastVal_Click(object sender, EventArgs e)
        {

            OpenChildForm(new LastVal(), sender);
        }

        private void Db_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DB(), sender);
        }

        private void Online_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Online(), sender);
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
