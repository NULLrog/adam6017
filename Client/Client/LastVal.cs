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
    public partial class LastVal : Form
    {
        public LastVal()
        {
            InitializeComponent();
        }

        //public NetworkStream stream;
        byte[] data = new byte[256];
        string message;

        private void LastVal_Load(object sender, EventArgs e)
        {

        }

        private string getValue(int ch)
        {
            message = ch.ToString();
            data = System.Text.Encoding.UTF8.GetBytes(message);
            Main.stream.Write(data, 0, data.Length);
            data = new byte[256];
            int bytes = Main.stream.Read(data, 0, data.Length);
            message = Encoding.UTF8.GetString(data, 0, bytes);
            textBox9.Text = DateTime.Now.ToString();
            return message;
        }

        private void GetAll_Click(object sender, EventArgs e)
        {
            textBox1.Text = getValue(0);
            textBox2.Text = getValue(1);
            textBox3.Text = getValue(2);
            textBox4.Text = getValue(3);
            textBox5.Text = getValue(4);
            textBox6.Text = getValue(5);
            textBox7.Text = getValue(6);
            textBox8.Text = getValue(7);
        }

        private void Get0_Click(object sender, EventArgs e)
        {
            textBox1.Text = getValue(0);
        }

        private void Get1_Click(object sender, EventArgs e)
        {
            textBox2.Text = getValue(1);
        }

        private void Get2_Click(object sender, EventArgs e)
        {
            textBox3.Text = getValue(2);
        }

        private void Get3_Click(object sender, EventArgs e)
        {
            textBox4.Text = getValue(3);
        }

        private void Get4_Click(object sender, EventArgs e)
        {
            textBox5.Text = getValue(4);
        }

        private void Get5_Click(object sender, EventArgs e)
        {
            textBox6.Text = getValue(5);
        }

        private void Get6_Click(object sender, EventArgs e)
        {
            textBox7.Text = getValue(6);
        }

        private void Get7_Click(object sender, EventArgs e)
        {
            textBox8.Text = getValue(7);
        }
    }
}
