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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NetworkStream stream; 
        byte[] data = new byte[256];
        string message;

        private void Form1_Load(object sender, EventArgs e)
        {
            maskedTextBox1.PromptChar = ' ';
            //maskedTextBox1.Text = "192.168.31.164";
            maskedTextBox1.Text = "   .   .   .   ";
            maskedTextBox1.Mask = "009.009.009.900";
            maskedTextBox1.ResetOnSpace = false;
            maskedTextBox1.SkipLiterals = false;
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            data = new byte[256];
            TcpClient t = new TcpClient(AddressFamily.InterNetwork);
            IPAddress[] IPAddresses;
            IPAddresses = Dns.GetHostAddresses(maskedTextBox1.Text.Replace(" ", ""));
            t.Connect(IPAddresses, 12345);
            stream = t.GetStream();
            int bytes = stream.Read(data, 0, data.Length);
            message = Encoding.UTF8.GetString(data, 0, bytes);
            MessageBox.Show(message);
            maskedTextBox1.Enabled = false;
            connect.Enabled = false;
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            data = new byte[256];
            message = "exit";
            data = System.Text.Encoding.UTF8.GetBytes(message);
            stream.Write(data, 0, data.Length);
            maskedTextBox1.Enabled = true;
            connect.Enabled = true;
            stream.Close();
        }

        private string getValue(int ch)
        {
            message = ch.ToString();
            data = System.Text.Encoding.UTF8.GetBytes(message); 
            stream.Write(data, 0, data.Length);
            data = new byte[256];
            int bytes = stream.Read(data, 0, data.Length);
            message = Encoding.UTF8.GetString(data, 0, bytes);
           
            return message;
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
