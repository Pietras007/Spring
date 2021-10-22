using LiveCharts;
using LiveCharts.Wpf;
using Spring.Functions;
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

namespace Spring
{
    public partial class Spring : Form
    {
        Thread thread;
        public Spring()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.InitialLocationTextBox.Text = "1.0";
            this.InitialSpeedTextBox.Text = "1.0";
            this.IntegrationStepTextBox.Text = "1.0";
            this.MassTextBox.Text = "1.0";
            this.TenacityRateTextBox.Text = "1.0";
            this.ResilienceTextBox.Text = "1.0";
            this.WFunctionCobmoBox.SelectedIndex = 0;
            this.A_WTextBox.Text = "1.0";
            this.HFunctionCobmoBox.SelectedIndex = 0;
            this.A_HTextBox.Text = "1.0";

            this.InitializeCharts();
        }

        private void InitialLocationTextBox_TextChanged(object sender, EventArgs e)
        {
            this.RecalculateCharts();
        }

        private void InitialSpeedTextBox_TextChanged(object sender, EventArgs e)
        {
            this.RecalculateCharts();
        }

        private void IntegrationStepTextBox_TextChanged(object sender, EventArgs e)
        {
            this.RecalculateCharts();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.RecalculateCharts();
        }

        private void TenacityRateTextBox_TextChanged(object sender, EventArgs e)
        {
            this.RecalculateCharts();
        }

        private void ResilienceTextBox_TextChanged(object sender, EventArgs e)
        {
            this.RecalculateCharts();
        }

        private void WFunctionCobmoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RecalculateCharts();
        }
        private void A_WTextBox_TextChanged(object sender, EventArgs e)
        {
            this.RecalculateCharts();
        }

        private void HFunctionCobmoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RecalculateCharts();
        }

        private void A_HTextBox_TextChanged(object sender, EventArgs e)
        {
            this.RecalculateCharts();
        }

        private void InitializeCharts()
        {
            cartesianChart_h_t.AnimationsSpeed = TimeSpan.Zero;
            cartesianChart_h_t.AutoSize = false;
            cartesianChart_h_t.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "time",
                Labels = new[] { "1", "2" }
            });

            cartesianChart_h_t.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Revenue",
                LabelFormatter = value => value.ToString()
            });
            RecalculateCharts();
        }

        private void RecalculateCharts()
        {
            if(thread != null)
            {
                thread.Abort();
            }

            Random random = new Random();
            double time_ms = 0;
            List<double> f_t_seriesValues = new List<double>();
            List<double> g_t_seriesValues = new List<double>();
            List<double> h_t_seriesValues = new List<double>();
            List<double> h_t_seriesValues2 = new List<double>();
            int HFunctionSelectedIndex = HFunctionCobmoBox.SelectedIndex;
            string A_HText = A_HTextBox.Text;
            for (int i = 0; i < 200; i++)
            {
                f_t_seriesValues.Add(double.MinValue);
                g_t_seriesValues.Add(double.MinValue);
                h_t_seriesValues.Add(double.MinValue);
                h_t_seriesValues2.Add(0);
            }

            thread = new Thread(() =>
            {
                while (true)
                {
                    
                    SeriesCollection f_t_series = new SeriesCollection();
                    //List<double> f_t_seriesValues = new List<double>();

                    SeriesCollection g_t_series = new SeriesCollection();
                    //List<double> g_t_seriesValues = new List<double>();

                    SeriesCollection h_t_series = new SeriesCollection();
                    HWFunction.CountHW(HFunctionSelectedIndex, A_HText, h_t_seriesValues, h_t_seriesValues2, time_ms, 3.14, 0);
                    foreach(var x in h_t_seriesValues2)
                    {
                        if(x == 0)
                        {
                            var z = 0;
                        }
                    }


                    int timestep = 100;
                    time_ms += timestep;

                    this.Invoke((MethodInvoker)delegate
                    {
                        //f_t_series.Add(new LineSeries() { Title = "dupa", Values = new ChartValues<double>(f_t_seriesValues) });
                        //g_t_series.Add(new LineSeries() { Title = "dupa", Values = new ChartValues<double>(g_t_seriesValues) });
                        h_t_series.Add(new LineSeries() { Title = "dupa", Values = new ChartValues<double>(h_t_seriesValues2) });

                        cartesianChart_f_t.Series = f_t_series;
                        cartesianChart_g_t.Series = g_t_series;
                        cartesianChart_h_t.Series = h_t_series;
                    });
                    Thread.Sleep(timestep);
                }
            });

            thread.Start();


        }
    }
}
