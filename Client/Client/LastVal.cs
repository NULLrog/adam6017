using System;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class LastVal : Form
    {
        public LastVal()
        {
            InitializeComponent();
        }

        byte[] data = new byte[256];
        string message;

        private string getValue(int ch)
        {
            message = ch.ToString();
            data = System.Text.Encoding.UTF8.GetBytes(message);
            Main.stream.Write(data, 0, data.Length);
            data = new byte[256];
            int bytes = Main.stream.Read(data, 0, data.Length);
            message = Encoding.UTF8.GetString(data, 0, bytes);
            dateBox.Text = DateTime.Now.ToString();
            return message;
        }

        private void GetAll_Click(object sender, EventArgs e)
        {
            ch0Box.Text = getValue(0);
            ch1Box.Text = getValue(1);
            ch2Box.Text = getValue(2);
            ch3Box.Text = getValue(3);
            ch4Box.Text = getValue(4);
            ch5Box.Text = getValue(5);
            ch6Box.Text = getValue(6);
            ch7Box.Text = getValue(7);
        }

        private void Get0_Click(object sender, EventArgs e)
        {
            ch0Box.Text = getValue(0);
        }

        private void Get1_Click(object sender, EventArgs e)
        {
            ch1Box.Text = getValue(1);
        }

        private void Get2_Click(object sender, EventArgs e)
        {
            ch2Box.Text = getValue(2);
        }

        private void Get3_Click(object sender, EventArgs e)
        {
            ch3Box.Text = getValue(3);
        }

        private void Get4_Click(object sender, EventArgs e)
        {
            ch4Box.Text = getValue(4);
        }

        private void Get5_Click(object sender, EventArgs e)
        {
            ch5Box.Text = getValue(5);
        }

        private void Get6_Click(object sender, EventArgs e)
        {
            ch6Box.Text = getValue(6);
        }

        private void Get7_Click(object sender, EventArgs e)
        {
            ch7Box.Text = getValue(7);
        }

        private void LastVal_Load(object sender, EventArgs e)
        {

        }
    }
}
