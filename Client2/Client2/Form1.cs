using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Client2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //maskedTextBox1.Text = "192.168.31.164";
            maskedTextBox1.Text = "   .   .   .   ";
            maskedTextBox1.Mask = "009.009.009.900";
        }

        MySqlConnection con = new MySqlConnection();

        private void Connect_Click(object sender, EventArgs e)
        {
            string IP = maskedTextBox1.Text.Replace(" ", "");
            string connStr = "server=" + IP + "; user=root; database=adam; password=password; port=3306";
            con = new MySqlConnection(connStr);
            connect.Enabled = false;
            maskedTextBox1.Enabled = false;
            disconnect.Enabled = true;
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            connect.Enabled = true;
            maskedTextBox1.Enabled = true;
            disconnect.Enabled = false;
        }

        private string getValue(int ch)
        {
            con.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = con;
            command.Parameters.Add("@ch", MySqlDbType.Text);
            switch (ch)
            {
                case 0:
                    command.CommandText = "select * from ch0 order by id desc limit 1";
                    break;
                case 1:
                    command.CommandText = "select * from ch1 order by id desc limit 1";
                    break;
                case 2:
                    command.CommandText = "select * from ch2 order by id desc limit 1";
                    break;
                case 3:
                    command.CommandText = "select * from ch3 order by id desc limit 1";
                    break;
                case 4:
                    command.CommandText = "select * from ch4 order by id desc limit 1";
                    break;
                case 5:
                    command.CommandText = "select * from ch5 order by id desc limit 1";
                    break;
                case 6:
                    command.CommandText = "select * from ch6 order by id desc limit 1";
                    break;
                case 7:
                    command.CommandText = "select * from ch7 order by id desc limit 1";
                    break;
            }
            MySqlDataReader reader = command.ExecuteReader();
            string val = "";
            while (reader.Read())
            {
                val = reader[2].ToString();
                label3.Text = reader[1].ToString();
            }
            reader.Close();
            con.Close();
            return val;
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
