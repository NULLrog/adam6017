using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
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
            dateTimePickerFrom.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            dateTimePickerTo.CustomFormat = "dd.MM.yyyy HH:mm:ss";
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
                dateBox.Text = reader[1].ToString();
            }
            reader.Close();
            con.Close();
            return val;
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

        public static List<Adam> adams;
       
        private void Select_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            MySqlCommand command = new MySqlCommand();
            command.Connection = con;
            for (int i = 0; i < channelListBox.CheckedItems.Count; i++)
            {
                adams = new List<Adam>();
                con.Open();
                command.CommandText = "select * from " + channelListBox.CheckedItems[i].ToString().ToLower() + " where dt > '" +
                    dateTimePickerFrom.Value.ToString("yyyy-MM-dd HH:mm:ss") +
                    "' and dt < '" + dateTimePickerTo.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'";


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
                Series mySeriesOfPoint = new Series(channelListBox.CheckedItems[i].ToString());
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
    }
}
