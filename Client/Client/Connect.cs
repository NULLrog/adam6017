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
    public partial class Connect : Form
    {
        public Connect()
        {
            InitializeComponent();
        }

        public NetworkStream stream;
        public byte[] data = new byte[256];
        public string message;

        private void Connect_Load(object sender, EventArgs e)
        {
            maskedTextBox1.PromptChar = ' ';
            maskedTextBox1.Text = "192.168.31.164";
            //maskedTextBox1.Text = "   .   .   .   ";
            //maskedTextBox1.Mask = "009.009.009.900";
            maskedTextBox1.ResetOnSpace = false;
            maskedTextBox1.SkipLiterals = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            data = new byte[256];
            TcpClient t = new TcpClient(AddressFamily.InterNetwork);
            IPAddress[] IPAddresses;
            IPAddresses = Dns.GetHostAddresses(maskedTextBox1.Text.Replace(" ", ""));
            try
            {
                t.Connect(IPAddresses, 12345);
            }
            catch
            {
                MessageBox.Show("Подключение недоступно! Повторите попытку позже!");
                return;
            }
            stream = t.GetStream();
            int bytes = stream.Read(data, 0, data.Length);
            message = Encoding.UTF8.GetString(data, 0, bytes);
            MessageBox.Show(message);
            Main m = new Main();
            Main.stream = stream;
            Main.ip = maskedTextBox1.Text;
            m.data = data;
            m.message = message;
            m.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
