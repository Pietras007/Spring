using OxyPlot;
using Spring.Functions;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Spring
{
    public partial class Spring : Form
    {
        Thread thread;
        PlotModel f_tPlotModel = new PlotModel();
        PlotModel g_tPlotModel = new PlotModel();
        PlotModel h_tPlotModel = new PlotModel();
        PlotModel w_tPlotModel = new PlotModel();

        PlotModel x_tPlotModel = new PlotModel();
        PlotModel xt_tPlotModel = new PlotModel();
        PlotModel xtt_tPlotModel = new PlotModel();

        bool started = false;
        int pointsInChart = 1000;
        public Spring()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.InitialLocationTextBox.Text = "1.0";
            this.InitialSpeedTextBox.Text = "1.0";
            this.IntegrationStepTextBox.Text = "0.01";
            this.MassTextBox.Text = "1.0";
            this.TenacityRateTextBox.Text = "1.0";
            this.ResilienceTextBox.Text = "1.0";
            this.WFunctionCobmoBox.SelectedIndex = 0;
            this.A_WTextBox.Text = "1.0";
            this.w_WTextBox.Text = "1.0";
            this.q_WTextBox.Text = "1.0";
            this.HFunctionCobmoBox.SelectedIndex = 0;
            this.A_HTextBox.Text = "1.0";
            this.w_HTextBox.Text = "1.0";
            this.q_HTextBox.Text = "1.0";

            this.labelf_t.Text = "f(t)";
            this.labelg_t.Text = "g(t)";
            this.labelh_t.Text = "h(t)";
            this.labelw_t.Text = "w(t)";


            this.x_tLabel.Text = "x(t)";
            this.xt_tLabel.Text = "xt(t)";
            this.xtt_tLabel.Text = "xtt(t)";

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

        private void w_WTextBox_TextChanged(object sender, EventArgs e)
        {
            this.RecalculateCharts();
        }

        private void q_WTextBox_TextChanged(object sender, EventArgs e)
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

        private void w_HTextBox_TextChanged(object sender, EventArgs e)
        {
            this.RecalculateCharts();
        }

        private void q_HTextBox_TextChanged(object sender, EventArgs e)
        {
            this.RecalculateCharts();
        }

        private void InitializeCharts()
        {
            //f(t)
            f_tPlotModel.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Left, Minimum = -20, Maximum = 20 });
            f_tPlotModel.Series.Add(new OxyPlot.Series.LineSeries { LineStyle = LineStyle.Solid, Color = OxyColor.FromRgb(255, 0, 0) });
            plotViewf_t.Model = f_tPlotModel;

            //g(t)
            g_tPlotModel.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Left, Minimum = -20, Maximum = 20 });
            g_tPlotModel.Series.Add(new OxyPlot.Series.LineSeries { LineStyle = LineStyle.Solid, Color = OxyColor.FromRgb(255, 0, 0) });
            plotViewg_t.Model = g_tPlotModel;

            //h(t)
            h_tPlotModel.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Left, Minimum = -20, Maximum = 20 });
            h_tPlotModel.Series.Add(new OxyPlot.Series.LineSeries { LineStyle = LineStyle.Solid, Color = OxyColor.FromRgb(255, 0, 0) });
            plotViewh_t.Model = h_tPlotModel;

            //MainViewModel class2 = new MainViewModel();
            //plotVieww_t.Model = class2.PlotModel;
            //w(t)
            w_tPlotModel.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Left, Minimum = -20, Maximum = 20 });
            w_tPlotModel.Series.Add(new OxyPlot.Series.LineSeries { LineStyle = LineStyle.Solid, Color = OxyColor.FromRgb(255, 0, 0) });
            plotVieww_t.Model = w_tPlotModel;

            //x(t)
            x_tPlotModel.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Left, Minimum = -20, Maximum = 20 });
            x_tPlotModel.Series.Add(new OxyPlot.Series.LineSeries { LineStyle = LineStyle.Solid, Color = OxyColor.FromRgb(255, 0, 0) });
            plotViewx_t.Model = x_tPlotModel;

            //xt(t)
            xt_tPlotModel.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Left, Minimum = -20, Maximum = 20 });
            xt_tPlotModel.Series.Add(new OxyPlot.Series.LineSeries { LineStyle = LineStyle.Solid, Color = OxyColor.FromRgb(255, 0, 0) });
            plotViewxt_t.Model = xt_tPlotModel;

            //xtt(t)
            xtt_tPlotModel.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Left, Minimum = -20, Maximum = 20 });
            xtt_tPlotModel.Series.Add(new OxyPlot.Series.LineSeries { LineStyle = LineStyle.Solid, Color = OxyColor.FromRgb(255, 0, 0) });
            plotViewxtt_t.Model = xtt_tPlotModel;


            started = true;
            RecalculateCharts();
        }

        private void RecalculateCharts()
        {
            string x_0 = InitialLocationTextBox.Text;
            string v_0 = InitialSpeedTextBox.Text;
            string delta_step = IntegrationStepTextBox.Text;
            string mass = MassTextBox.Text;
            string tenacityRate = TenacityRateTextBox.Text;
            string resilience = ResilienceTextBox.Text;

            int WFunctionSelectedIndex = WFunctionCobmoBox.SelectedIndex;
            string A_WText = A_WTextBox.Text;
            string w_WText = w_WTextBox.Text;
            string q_WText = q_WTextBox.Text;

            int HFunctionSelectedIndex = HFunctionCobmoBox.SelectedIndex;
            string A_HText = A_HTextBox.Text;
            string w_HText = w_HTextBox.Text;
            string q_HText = q_HTextBox.Text;
            if (started)
            {
                double xi = 0, vi = 0, delta = 0, m = 0, k = 0, c = 0, A_w = 0, w_w = 0, q_w = 0, A_h = 0, w_h = 0, q_h = 0;
                if (double.TryParse(x_0, out xi) &&
                    double.TryParse(v_0, out vi) &&
                    double.TryParse(delta_step, out delta) &&
                    double.TryParse(mass, out m) &&
                    double.TryParse(tenacityRate, out k) &&
                    double.TryParse(resilience, out c) &&
                    double.TryParse(A_WText, out A_w) &&
                    double.TryParse(w_WText, out w_w) &&
                    double.TryParse(q_WText, out q_w) &&
                    double.TryParse(A_HText, out A_h) &&
                    double.TryParse(w_HText, out w_h) &&
                    double.TryParse(q_HText, out q_h))
                {

                    var f_tS = (OxyPlot.Series.LineSeries)f_tPlotModel.Series[0];
                    var g_tS = (OxyPlot.Series.LineSeries)g_tPlotModel.Series[0];
                    var h_tS = (OxyPlot.Series.LineSeries)h_tPlotModel.Series[0];
                    var w_tS = (OxyPlot.Series.LineSeries)w_tPlotModel.Series[0];

                    var x_tS = (OxyPlot.Series.LineSeries)x_tPlotModel.Series[0];
                    var xt_tS = (OxyPlot.Series.LineSeries)xt_tPlotModel.Series[0];
                    var xtt_tS = (OxyPlot.Series.LineSeries)xtt_tPlotModel.Series[0];
                    double time_ms = 0.0;
                    if (thread != null)
                    {
                        thread.Abort();
                    }

                    f_tS.Points.Clear();
                    g_tS.Points.Clear();
                    h_tS.Points.Clear();
                    w_tS.Points.Clear();

                    x_tS.Points.Clear();
                    xt_tS.Points.Clear();
                    xtt_tS.Points.Clear();
                    for (int i = pointsInChart; i > 0; i--)
                    {
                        f_tS.Points.Add(new DataPoint(-i * delta, 0));
                        g_tS.Points.Add(new DataPoint(-i * delta, 0));
                        h_tS.Points.Add(new DataPoint(-i * delta, 0));
                        w_tS.Points.Add(new DataPoint(-i * delta, 0));

                        x_tS.Points.Add(new DataPoint(-i * delta, 0));
                        xt_tS.Points.Add(new DataPoint(-i * delta, 0));
                        xtt_tS.Points.Add(new DataPoint(-i * delta, 0));
                    }

                    f_tPlotModel.InvalidatePlot(true);
                    g_tPlotModel.InvalidatePlot(true);
                    h_tPlotModel.InvalidatePlot(true);
                    w_tPlotModel.InvalidatePlot(true);

                    x_tPlotModel.InvalidatePlot(true);
                    xt_tPlotModel.InvalidatePlot(true);
                    xtt_tPlotModel.InvalidatePlot(true);

                    thread = new Thread(() =>
                    {
                        while (true)
                        {
                            double h_tValue = HWFunction.CountHW(HFunctionSelectedIndex, A_h, time_ms, w_h, q_h);
                            double w_tValue = HWFunction.CountHW(WFunctionSelectedIndex, A_w, time_ms, w_w, q_w);
                            double f_tvalue = c * (w_tValue - xi);
                            double g_tvalue = -k * vi;
                            double xi_1 = delta * vi + xi;
                            double vi_1 = delta * (f_tvalue + g_tvalue + h_tValue) / m + vi;
                            double x_tvalue = xi;
                            double xt_tvalue = vi;
                            double xtt_tValue = (f_tvalue + g_tvalue + h_tValue) / m;


                            lock (f_tPlotModel.SyncRoot)
                            {
                                f_tS.Points.RemoveAt(0);
                                f_tS.Points.Add(new DataPoint(time_ms, f_tvalue));
                            }

                            lock (g_tPlotModel.SyncRoot)
                            {
                                g_tS.Points.RemoveAt(0);
                                g_tS.Points.Add(new DataPoint(time_ms, g_tvalue));
                            }

                            lock (h_tPlotModel.SyncRoot)
                            {
                                h_tS.Points.RemoveAt(0);
                                h_tS.Points.Add(new DataPoint(time_ms, h_tValue));
                            }

                            lock (w_tPlotModel.SyncRoot)
                            {
                                w_tS.Points.RemoveAt(0);
                                w_tS.Points.Add(new DataPoint(time_ms, w_tValue));
                            }

                            lock (x_tPlotModel.SyncRoot)
                            {
                                x_tS.Points.RemoveAt(0);
                                x_tS.Points.Add(new DataPoint(time_ms, x_tvalue));
                            }

                            lock (xt_tPlotModel.SyncRoot)
                            {
                                xt_tS.Points.RemoveAt(0);
                                xt_tS.Points.Add(new DataPoint(time_ms, xt_tvalue));
                            }

                            lock (xtt_tPlotModel.SyncRoot)
                            {
                                xtt_tS.Points.RemoveAt(0);
                                xtt_tS.Points.Add(new DataPoint(time_ms, xtt_tValue));
                            }

                            f_tPlotModel.InvalidatePlot(true);
                            g_tPlotModel.InvalidatePlot(true);
                            h_tPlotModel.InvalidatePlot(true);
                            w_tPlotModel.InvalidatePlot(true);

                            x_tPlotModel.InvalidatePlot(true);
                            xt_tPlotModel.InvalidatePlot(true);
                            xtt_tPlotModel.InvalidatePlot(true);
                            Thread.Sleep((int)(delta * 1000));
                            time_ms += delta;
                            xi = xi_1;
                            vi = vi_1;
                        }
                    });

                    thread.IsBackground = false;
                    thread.Start();
                }
                else
                {

                    MessageBox.Show("NaN");
                }
            }
        }
    }
}
