using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;
using Timer = System.Windows.Forms.Timer;

namespace Client
{
    public partial class Online : Form
    {
        public Online()
        {
            InitializeComponent();
        }
        byte[] data = new byte[256];
        string message;

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

        private void Graphic()
        {
            double a;
            if (radioButton1.Checked == true)
            {
               a = double.Parse(getValue(0), CultureInfo.InvariantCulture);
            }
            if (radioButton2.Checked == true)
            {
                a = double.Parse(getValue(1), CultureInfo.InvariantCulture);
            }
            if (radioButton3.Checked == true)
            {
                a = double.Parse(getValue(2), CultureInfo.InvariantCulture);
            }
            if (radioButton4.Checked == true)
            {
                a = double.Parse(getValue(3), CultureInfo.InvariantCulture);
            }
            if (radioButton5.Checked == true)
            {
                a = double.Parse(getValue(4), CultureInfo.InvariantCulture);
            }
            if (radioButton6.Checked == true)
            {
                a = double.Parse(getValue(5), CultureInfo.InvariantCulture);
            }
            if (radioButton7.Checked == true)
            {
                a = double.Parse(getValue(6), CultureInfo.InvariantCulture);
            }
            else
            {
                a = double.Parse(getValue(7), CultureInfo.InvariantCulture);
            }
            chart1.Series[0].Points.AddXY(DateTime.Now, a);
            chart1.Series[0].Points.AddY(a);
            chart1.ChartAreas[0].AxisX.ScaleView.Position = chart1.Series[0].Points.Count - 5;
        }
       
        private string getValue(int ch)
        {
            message = ch.ToString();
            data = System.Text.Encoding.UTF8.GetBytes(message);
            Main.stream.Write(data, 0, data.Length);
            data = new byte[256];
            int bytes = Main.stream.Read(data, 0, data.Length);
            message = Encoding.UTF8.GetString(data, 0, bytes);
            return message;
        }

        private void Online_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            DateTime time = DateTime.Now;
            timer1.Interval = 1000;
            chart1.GetToolTipText += chart1_GetToolTipText;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            chart1.ChartAreas[0].AxisX.ScaleView.Size = 6;
            chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            chart1.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
        }

        private void Get_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            button1.Enabled = true;
            get.Enabled = false;
            groupBox1.Enabled = false;
            Series mySeriesOfPoint;
            if (radioButton1.Checked == true)
            {
                mySeriesOfPoint = new Series("Ch-0");
            }
            if (radioButton2.Checked == true)
            {
                mySeriesOfPoint = new Series("Ch-1");
            }
            if (radioButton3.Checked == true)
            {
                mySeriesOfPoint = new Series("Ch-2");
            }
            if (radioButton4.Checked == true)
            {
                mySeriesOfPoint = new Series("Ch-3");
            }
            if (radioButton5.Checked == true)
            {
                mySeriesOfPoint = new Series("Ch-4");
            }
            if (radioButton6.Checked == true)
            {
                mySeriesOfPoint = new Series("Ch-5");
            }
            if (radioButton7.Checked == true)
            {
                mySeriesOfPoint = new Series("Ch-6");
            }
            else
            {
                mySeriesOfPoint = new Series("Ch-7");
            }
            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            chart1.Series.Add(mySeriesOfPoint);
            chart1.Series[0].BorderWidth = 5;
            chart1.Series[0].IsXValueIndexed = true;
            chart1.Series[0].XValueType = ChartValueType.Time;
            timer1.Start();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button1.Enabled = false;
            get.Enabled = true;
            groupBox1.Enabled = true; 
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Graphic();
        }
    }
}
