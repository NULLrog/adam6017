using System;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;

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
                    e.Text = string.Format("Date:\t{0}\nVolts:\t{1}", DateTime.FromOADate(dataPoint.XValue).ToString("HH:mm:ss"), dataPoint.YValues[0]);
                    break;
            }
        }

        private void Graphic()
        {
            double a;
            if (ch0.Checked == true)
            {
               a = double.Parse(getValue(0), CultureInfo.InvariantCulture);
            }
            if (ch2.Checked == true)
            {
                a = double.Parse(getValue(1), CultureInfo.InvariantCulture);
            }
            if (ch1.Checked == true)
            {
                a = double.Parse(getValue(2), CultureInfo.InvariantCulture);
            }
            if (ch3.Checked == true)
            {
                a = double.Parse(getValue(3), CultureInfo.InvariantCulture);
            }
            if (ch4.Checked == true)
            {
                a = double.Parse(getValue(4), CultureInfo.InvariantCulture);
            }
            if (ch5.Checked == true)
            {
                a = double.Parse(getValue(5), CultureInfo.InvariantCulture);
            }
            if (ch6.Checked == true)
            {
                a = double.Parse(getValue(6), CultureInfo.InvariantCulture);
            }
            else
            {
                a = double.Parse(getValue(7), CultureInfo.InvariantCulture);
            }
            chart1.Series[0].Points.AddXY(DateTime.Now, a);
            chart1.ChartAreas[0].AxisX.ScaleView.Position = chart1.Series[0].Points.Count - 6;
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
            stop.Enabled = false;
            DateTime time = DateTime.Now;
            timer1.Interval = 1000;
            chart1.GetToolTipText += chart1_GetToolTipText;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Graphic();
        }

        private void start_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            stop.Enabled = true;
            start.Enabled = false;
            channelsBox.Enabled = false;
            Series mySeriesOfPoint;
            if (ch0.Checked == true)
            {
                mySeriesOfPoint = new Series("Ch-0");
            }
            else if (ch1.Checked == true)
            {
                mySeriesOfPoint = new Series("Ch-1");
            }
            else if (ch2.Checked == true)
            {
                mySeriesOfPoint = new Series("Ch-2");
            }
            else if (ch3.Checked == true)
            {
                mySeriesOfPoint = new Series("Ch-3");
            }
            else if (ch4.Checked == true)
            {
                mySeriesOfPoint = new Series("Ch-4");
            }
            else if (ch5.Checked == true)
            {
                mySeriesOfPoint = new Series("Ch-5");
            }
            else if (ch6.Checked == true)
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
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            chart1.ChartAreas[0].AxisX.ScaleView.Size = 6;
            chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            chart1.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
            chart1.ChartAreas[0].AxisY.ScaleView.ZoomReset();
            chart1.ChartAreas[0].AxisY.ScrollBar.Enabled = true;
            chart1.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart1.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;
            chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].CursorY.AutoScroll = true;
            chart1.ChartAreas[0].AxisX.ScaleView.SmallScrollMinSize = 60;
            chart1.ChartAreas[0].AxisY.ScaleView.SmallScrollMinSize = 0.1;
            timer1.Start();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            stop.Enabled = false;
            start.Enabled = true;
            channelsBox.Enabled = true;
        }
    }
}
