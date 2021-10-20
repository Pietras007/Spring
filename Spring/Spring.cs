using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spring
{
    public partial class Spring : Form
    {
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
        }

        private void RecalculateCharts()
        {
            
        }
    }
}
