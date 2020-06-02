using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Client
{
    public partial class DB : Form
    {
        public DB()
        {
            InitializeComponent();
            
        }
        MySqlConnection con = new MySqlConnection();

        private void chart1_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            switch (e.HitTestResult.ChartElementType)
            {
                case ChartElementType.DataPoint:
                    var dataPoint = e.HitTestResult.Series.Points[e.HitTestResult.PointIndex];
                    e.Text = string.Format("Date:\t{0}\nVolts:\t{1}", DateTime.FromOADate(dataPoint.XValue), dataPoint.YValues[0]);
                    break;
            }
        }
        private void DB_Load(object sender, EventArgs e)
        {
            string IP = Main.ip.Replace(" ", "");
            string connStr = "server=" + IP + "; user=root; database=adam; port=3306; password=password;";
            con = new MySqlConnection(connStr);
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            dateTimePicker2.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].CursorX.AutoScroll = true;
            chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = false;
            chart1.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].CursorY.AutoScroll = true;
            chart1.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = false;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss dd.MM.yyyy";
            chart1.ChartAreas[0].AxisX.ScaleView.SmallScrollMinSizeType = DateTimeIntervalType.Seconds;
            chart1.ChartAreas[0].AxisX.ScaleView.SmallScrollMinSize = 60;
            chart1.ChartAreas[0].AxisY.ScaleView.SmallScrollMinSize = 0.1;
            chart1.GetToolTipText += chart1_GetToolTipText;
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
                textBox9.Text = reader[1].ToString();
            }
            reader.Close();
            con.Close();
            return val;
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

        public static List<Adam> adams;
       
        private void Select_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            MySqlCommand command = new MySqlCommand();
            command.Connection = con;
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                adams = new List<Adam>();
                con.Open();
                command.CommandText = "select * from " + checkedListBox1.CheckedItems[i].ToString().ToLower() + " where dt > '" +
                    dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") +
                    "' and dt < '" + dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'";


                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    adams.Add(new Adam()
                    {
                        id = Convert.ToInt32(reader[0].ToString()),
                        dt = Convert.ToDateTime(reader[1].ToString()),
                        value = Convert.ToDouble(reader[2].ToString())
                    });
                }
                reader.Close();
                Series mySeriesOfPoint = new Series(checkedListBox1.CheckedItems[i].ToString());
                mySeriesOfPoint.XValueType = ChartValueType.DateTime;
                mySeriesOfPoint.ChartType = SeriesChartType.Line;
                for (int j = 0; j < adams.Count(); j++)
                {
                    mySeriesOfPoint.Points.AddXY(adams[j].dt.ToOADate(), adams[j].value);
                }
                chart1.Series.Add(mySeriesOfPoint);
                chart1.Series[i].BorderWidth = 5;
                con.Close();
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
