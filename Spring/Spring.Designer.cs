
namespace Spring
{
    partial class Spring
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HFunctionLabel = new System.Windows.Forms.Label();
            this.WFunctionLabel = new System.Windows.Forms.Label();
            this.HFunctionCobmoBox = new System.Windows.Forms.ComboBox();
            this.WFunctionCobmoBox = new System.Windows.Forms.ComboBox();
            this.A_HTextBox = new System.Windows.Forms.TextBox();
            this.AForHLabel = new System.Windows.Forms.Label();
            this.A_WTextBox = new System.Windows.Forms.TextBox();
            this.AForWLabel = new System.Windows.Forms.Label();
            this.ResilienceTextBox = new System.Windows.Forms.TextBox();
            this.ResilienceLabel = new System.Windows.Forms.Label();
            this.TenacityRateTextBox = new System.Windows.Forms.TextBox();
            this.TenacityRateLabel = new System.Windows.Forms.Label();
            this.MassTextBox = new System.Windows.Forms.TextBox();
            this.MassLabel = new System.Windows.Forms.Label();
            this.IntegrationStepTextBox = new System.Windows.Forms.TextBox();
            this.IntegrationStepLabel = new System.Windows.Forms.Label();
            this.InitialSpeedTextBox = new System.Windows.Forms.TextBox();
            this.InitialSpeedLabel = new System.Windows.Forms.Label();
            this.InitialLocationTextBox = new System.Windows.Forms.TextBox();
            this.InitialLocationLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cartesianChart_f_t = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChart_g_t = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChart_h_t = new LiveCharts.WinForms.CartesianChart();
            this.w_WTextBox = new System.Windows.Forms.TextBox();
            this.wforWLabel = new System.Windows.Forms.Label();
            this.q_WTextBox = new System.Windows.Forms.TextBox();
            this.qforWLabel = new System.Windows.Forms.Label();
            this.w_HTextBox = new System.Windows.Forms.TextBox();
            this.wforHLabel = new System.Windows.Forms.Label();
            this.q_HTextBox = new System.Windows.Forms.TextBox();
            this.qforHLabel = new System.Windows.Forms.Label();
            this.plotViewh_t = new OxyPlot.WindowsForms.PlotView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HFunctionLabel
            // 
            this.HFunctionLabel.AutoSize = true;
            this.HFunctionLabel.Location = new System.Drawing.Point(20, 482);
            this.HFunctionLabel.Name = "HFunctionLabel";
            this.HFunctionLabel.Size = new System.Drawing.Size(69, 13);
            this.HFunctionLabel.TabIndex = 20;
            this.HFunctionLabel.Text = "Function: h(t)";
            // 
            // WFunctionLabel
            // 
            this.WFunctionLabel.AutoSize = true;
            this.WFunctionLabel.Location = new System.Drawing.Point(20, 373);
            this.WFunctionLabel.Name = "WFunctionLabel";
            this.WFunctionLabel.Size = new System.Drawing.Size(71, 13);
            this.WFunctionLabel.TabIndex = 19;
            this.WFunctionLabel.Text = "Function: w(t)";
            // 
            // HFunctionCobmoBox
            // 
            this.HFunctionCobmoBox.FormattingEnabled = true;
            this.HFunctionCobmoBox.Items.AddRange(new object[] {
            "A (const)",
            "{ 0 t<0; A t>=0 }",
            "A*sgn(sin(wt + q))",
            "A*sin(wt + q)"});
            this.HFunctionCobmoBox.Location = new System.Drawing.Point(20, 500);
            this.HFunctionCobmoBox.Name = "HFunctionCobmoBox";
            this.HFunctionCobmoBox.Size = new System.Drawing.Size(151, 21);
            this.HFunctionCobmoBox.TabIndex = 18;
            this.HFunctionCobmoBox.SelectedIndexChanged += new System.EventHandler(this.HFunctionCobmoBox_SelectedIndexChanged);
            // 
            // WFunctionCobmoBox
            // 
            this.WFunctionCobmoBox.FormattingEnabled = true;
            this.WFunctionCobmoBox.Items.AddRange(new object[] {
            "A (const)",
            "{ 0 t<0; A t>=0 }",
            "A*sgn(sin(wt + q))",
            "A*sin(wt + q)"});
            this.WFunctionCobmoBox.Location = new System.Drawing.Point(20, 391);
            this.WFunctionCobmoBox.Name = "WFunctionCobmoBox";
            this.WFunctionCobmoBox.Size = new System.Drawing.Size(151, 21);
            this.WFunctionCobmoBox.TabIndex = 17;
            this.WFunctionCobmoBox.SelectedIndexChanged += new System.EventHandler(this.WFunctionCobmoBox_SelectedIndexChanged);
            // 
            // A_HTextBox
            // 
            this.A_HTextBox.Location = new System.Drawing.Point(22, 542);
            this.A_HTextBox.Name = "A_HTextBox";
            this.A_HTextBox.Size = new System.Drawing.Size(29, 20);
            this.A_HTextBox.TabIndex = 16;
            this.A_HTextBox.TextChanged += new System.EventHandler(this.A_HTextBox_TextChanged);
            // 
            // AForHLabel
            // 
            this.AForHLabel.AutoSize = true;
            this.AForHLabel.Location = new System.Drawing.Point(22, 524);
            this.AForHLabel.Name = "AForHLabel";
            this.AForHLabel.Size = new System.Drawing.Size(35, 13);
            this.AForHLabel.TabIndex = 15;
            this.AForHLabel.Text = "A: h(t)";
            // 
            // A_WTextBox
            // 
            this.A_WTextBox.Location = new System.Drawing.Point(20, 433);
            this.A_WTextBox.Name = "A_WTextBox";
            this.A_WTextBox.Size = new System.Drawing.Size(29, 20);
            this.A_WTextBox.TabIndex = 14;
            this.A_WTextBox.TextChanged += new System.EventHandler(this.A_WTextBox_TextChanged);
            // 
            // AForWLabel
            // 
            this.AForWLabel.AutoSize = true;
            this.AForWLabel.Location = new System.Drawing.Point(20, 415);
            this.AForWLabel.Name = "AForWLabel";
            this.AForWLabel.Size = new System.Drawing.Size(37, 13);
            this.AForWLabel.TabIndex = 13;
            this.AForWLabel.Text = "A: w(t)";
            // 
            // ResilienceTextBox
            // 
            this.ResilienceTextBox.Location = new System.Drawing.Point(20, 309);
            this.ResilienceTextBox.Name = "ResilienceTextBox";
            this.ResilienceTextBox.Size = new System.Drawing.Size(151, 20);
            this.ResilienceTextBox.TabIndex = 12;
            this.ResilienceTextBox.TextChanged += new System.EventHandler(this.ResilienceTextBox_TextChanged);
            // 
            // ResilienceLabel
            // 
            this.ResilienceLabel.AutoSize = true;
            this.ResilienceLabel.Location = new System.Drawing.Point(20, 291);
            this.ResilienceLabel.Name = "ResilienceLabel";
            this.ResilienceLabel.Size = new System.Drawing.Size(68, 13);
            this.ResilienceLabel.TabIndex = 11;
            this.ResilienceLabel.Text = "Resilience: c";
            // 
            // TenacityRateTextBox
            // 
            this.TenacityRateTextBox.Location = new System.Drawing.Point(20, 252);
            this.TenacityRateTextBox.Name = "TenacityRateTextBox";
            this.TenacityRateTextBox.Size = new System.Drawing.Size(151, 20);
            this.TenacityRateTextBox.TabIndex = 10;
            this.TenacityRateTextBox.TextChanged += new System.EventHandler(this.TenacityRateTextBox_TextChanged);
            // 
            // TenacityRateLabel
            // 
            this.TenacityRateLabel.AutoSize = true;
            this.TenacityRateLabel.Location = new System.Drawing.Point(20, 234);
            this.TenacityRateLabel.Name = "TenacityRateLabel";
            this.TenacityRateLabel.Size = new System.Drawing.Size(86, 13);
            this.TenacityRateLabel.TabIndex = 9;
            this.TenacityRateLabel.Text = "Tenacity Rate: k";
            // 
            // MassTextBox
            // 
            this.MassTextBox.Location = new System.Drawing.Point(20, 196);
            this.MassTextBox.Name = "MassTextBox";
            this.MassTextBox.Size = new System.Drawing.Size(151, 20);
            this.MassTextBox.TabIndex = 8;
            this.MassTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // MassLabel
            // 
            this.MassLabel.AutoSize = true;
            this.MassLabel.Location = new System.Drawing.Point(20, 178);
            this.MassLabel.Name = "MassLabel";
            this.MassLabel.Size = new System.Drawing.Size(46, 13);
            this.MassLabel.TabIndex = 7;
            this.MassLabel.Text = "Mass: m";
            // 
            // IntegrationStepTextBox
            // 
            this.IntegrationStepTextBox.Location = new System.Drawing.Point(20, 144);
            this.IntegrationStepTextBox.Name = "IntegrationStepTextBox";
            this.IntegrationStepTextBox.Size = new System.Drawing.Size(151, 20);
            this.IntegrationStepTextBox.TabIndex = 6;
            this.IntegrationStepTextBox.TextChanged += new System.EventHandler(this.IntegrationStepTextBox_TextChanged);
            // 
            // IntegrationStepLabel
            // 
            this.IntegrationStepLabel.AutoSize = true;
            this.IntegrationStepLabel.Location = new System.Drawing.Point(20, 126);
            this.IntegrationStepLabel.Name = "IntegrationStepLabel";
            this.IntegrationStepLabel.Size = new System.Drawing.Size(114, 13);
            this.IntegrationStepLabel.TabIndex = 5;
            this.IntegrationStepLabel.Text = "Integration Step (delta)";
            // 
            // InitialSpeedTextBox
            // 
            this.InitialSpeedTextBox.Location = new System.Drawing.Point(20, 91);
            this.InitialSpeedTextBox.Name = "InitialSpeedTextBox";
            this.InitialSpeedTextBox.Size = new System.Drawing.Size(151, 20);
            this.InitialSpeedTextBox.TabIndex = 4;
            this.InitialSpeedTextBox.TextChanged += new System.EventHandler(this.InitialSpeedTextBox_TextChanged);
            // 
            // InitialSpeedLabel
            // 
            this.InitialSpeedLabel.AutoSize = true;
            this.InitialSpeedLabel.Location = new System.Drawing.Point(20, 73);
            this.InitialSpeedLabel.Name = "InitialSpeedLabel";
            this.InitialSpeedLabel.Size = new System.Drawing.Size(89, 13);
            this.InitialSpeedLabel.TabIndex = 3;
            this.InitialSpeedLabel.Text = "Initial Speed: v(0)";
            // 
            // InitialLocationTextBox
            // 
            this.InitialLocationTextBox.Location = new System.Drawing.Point(20, 38);
            this.InitialLocationTextBox.Name = "InitialLocationTextBox";
            this.InitialLocationTextBox.Size = new System.Drawing.Size(151, 20);
            this.InitialLocationTextBox.TabIndex = 2;
            this.InitialLocationTextBox.TextChanged += new System.EventHandler(this.InitialLocationTextBox_TextChanged);
            // 
            // InitialLocationLabel
            // 
            this.InitialLocationLabel.AutoSize = true;
            this.InitialLocationLabel.Location = new System.Drawing.Point(20, 20);
            this.InitialLocationLabel.Name = "InitialLocationLabel";
            this.InitialLocationLabel.Size = new System.Drawing.Size(98, 13);
            this.InitialLocationLabel.TabIndex = 1;
            this.InitialLocationLabel.Text = "Initial Location: x(0)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.q_HTextBox);
            this.panel1.Controls.Add(this.qforHLabel);
            this.panel1.Controls.Add(this.w_HTextBox);
            this.panel1.Controls.Add(this.wforHLabel);
            this.panel1.Controls.Add(this.q_WTextBox);
            this.panel1.Controls.Add(this.qforWLabel);
            this.panel1.Controls.Add(this.w_WTextBox);
            this.panel1.Controls.Add(this.wforWLabel);
            this.panel1.Controls.Add(this.HFunctionLabel);
            this.panel1.Controls.Add(this.WFunctionLabel);
            this.panel1.Controls.Add(this.HFunctionCobmoBox);
            this.panel1.Controls.Add(this.WFunctionCobmoBox);
            this.panel1.Controls.Add(this.A_HTextBox);
            this.panel1.Controls.Add(this.AForHLabel);
            this.panel1.Controls.Add(this.A_WTextBox);
            this.panel1.Controls.Add(this.AForWLabel);
            this.panel1.Controls.Add(this.ResilienceTextBox);
            this.panel1.Controls.Add(this.ResilienceLabel);
            this.panel1.Controls.Add(this.TenacityRateTextBox);
            this.panel1.Controls.Add(this.TenacityRateLabel);
            this.panel1.Controls.Add(this.MassTextBox);
            this.panel1.Controls.Add(this.MassLabel);
            this.panel1.Controls.Add(this.IntegrationStepTextBox);
            this.panel1.Controls.Add(this.IntegrationStepLabel);
            this.panel1.Controls.Add(this.InitialSpeedTextBox);
            this.panel1.Controls.Add(this.InitialSpeedLabel);
            this.panel1.Controls.Add(this.InitialLocationTextBox);
            this.panel1.Controls.Add(this.InitialLocationLabel);
            this.panel1.Location = new System.Drawing.Point(952, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 596);
            this.panel1.TabIndex = 0;
            // 
            // cartesianChart_f_t
            // 
            this.cartesianChart_f_t.Location = new System.Drawing.Point(12, 14);
            this.cartesianChart_f_t.Name = "cartesianChart_f_t";
            this.cartesianChart_f_t.Size = new System.Drawing.Size(287, 164);
            this.cartesianChart_f_t.TabIndex = 1;
            this.cartesianChart_f_t.Text = "cartesianChart1";
            // 
            // cartesianChart_g_t
            // 
            this.cartesianChart_g_t.Location = new System.Drawing.Point(323, 14);
            this.cartesianChart_g_t.Name = "cartesianChart_g_t";
            this.cartesianChart_g_t.Size = new System.Drawing.Size(287, 164);
            this.cartesianChart_g_t.TabIndex = 2;
            this.cartesianChart_g_t.Text = "cartesianChart2";
            // 
            // cartesianChart_h_t
            // 
            this.cartesianChart_h_t.Location = new System.Drawing.Point(630, 14);
            this.cartesianChart_h_t.Name = "cartesianChart_h_t";
            this.cartesianChart_h_t.Size = new System.Drawing.Size(287, 164);
            this.cartesianChart_h_t.TabIndex = 3;
            this.cartesianChart_h_t.Text = "cartesianChart3";
            // 
            // w_WTextBox
            // 
            this.w_WTextBox.Location = new System.Drawing.Point(77, 433);
            this.w_WTextBox.Name = "w_WTextBox";
            this.w_WTextBox.Size = new System.Drawing.Size(29, 20);
            this.w_WTextBox.TabIndex = 22;
            // 
            // wforWLabel
            // 
            this.wforWLabel.AutoSize = true;
            this.wforWLabel.Location = new System.Drawing.Point(77, 415);
            this.wforWLabel.Name = "wforWLabel";
            this.wforWLabel.Size = new System.Drawing.Size(38, 13);
            this.wforWLabel.TabIndex = 21;
            this.wforWLabel.Text = "w: w(t)";
            // 
            // q_WTextBox
            // 
            this.q_WTextBox.Location = new System.Drawing.Point(131, 433);
            this.q_WTextBox.Name = "q_WTextBox";
            this.q_WTextBox.Size = new System.Drawing.Size(29, 20);
            this.q_WTextBox.TabIndex = 24;
            // 
            // qforWLabel
            // 
            this.qforWLabel.AutoSize = true;
            this.qforWLabel.Location = new System.Drawing.Point(131, 415);
            this.qforWLabel.Name = "qforWLabel";
            this.qforWLabel.Size = new System.Drawing.Size(36, 13);
            this.qforWLabel.TabIndex = 23;
            this.qforWLabel.Text = "q: w(t)";
            // 
            // w_HTextBox
            // 
            this.w_HTextBox.Location = new System.Drawing.Point(77, 542);
            this.w_HTextBox.Name = "w_HTextBox";
            this.w_HTextBox.Size = new System.Drawing.Size(29, 20);
            this.w_HTextBox.TabIndex = 26;
            // 
            // wforHLabel
            // 
            this.wforHLabel.AutoSize = true;
            this.wforHLabel.Location = new System.Drawing.Point(77, 524);
            this.wforHLabel.Name = "wforHLabel";
            this.wforHLabel.Size = new System.Drawing.Size(36, 13);
            this.wforHLabel.TabIndex = 25;
            this.wforHLabel.Text = "w: h(t)";
            // 
            // q_HTextBox
            // 
            this.q_HTextBox.Location = new System.Drawing.Point(131, 542);
            this.q_HTextBox.Name = "q_HTextBox";
            this.q_HTextBox.Size = new System.Drawing.Size(29, 20);
            this.q_HTextBox.TabIndex = 28;
            // 
            // qforHLabel
            // 
            this.qforHLabel.AutoSize = true;
            this.qforHLabel.Location = new System.Drawing.Point(131, 524);
            this.qforHLabel.Name = "qforHLabel";
            this.qforHLabel.Size = new System.Drawing.Size(34, 13);
            this.qforHLabel.TabIndex = 27;
            this.qforHLabel.Text = "q: h(t)";
            // plotViewh_t
            // 
            this.plotViewh_t.Location = new System.Drawing.Point(660, 210);
            this.plotViewh_t.Name = "plotViewh_t";
            this.plotViewh_t.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotViewh_t.Size = new System.Drawing.Size(257, 203);
            this.plotViewh_t.TabIndex = 4;
            this.plotViewh_t.Text = "plotView1";
            this.plotViewh_t.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotViewh_t.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotViewh_t.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // Spring
            // 
            // Spring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 622);
            this.Controls.Add(this.plotViewh_t);
            this.Controls.Add(this.cartesianChart_h_t);
            this.Controls.Add(this.cartesianChart_g_t);
            this.Controls.Add(this.cartesianChart_f_t);
            this.Controls.Add(this.panel1);
            this.Name = "Spring";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ResilienceTextBox;
        private System.Windows.Forms.Label ResilienceLabel;
        private System.Windows.Forms.TextBox TenacityRateTextBox;
        private System.Windows.Forms.Label TenacityRateLabel;
        private System.Windows.Forms.TextBox MassTextBox;
        private System.Windows.Forms.Label MassLabel;
        private System.Windows.Forms.TextBox IntegrationStepTextBox;
        private System.Windows.Forms.Label IntegrationStepLabel;
        private System.Windows.Forms.TextBox InitialSpeedTextBox;
        private System.Windows.Forms.Label InitialSpeedLabel;
        private System.Windows.Forms.TextBox InitialLocationTextBox;
        private System.Windows.Forms.Label InitialLocationLabel;
        private System.Windows.Forms.TextBox A_HTextBox;
        private System.Windows.Forms.Label AForHLabel;
        private System.Windows.Forms.TextBox A_WTextBox;
        private System.Windows.Forms.Label AForWLabel;
        private System.Windows.Forms.ComboBox WFunctionCobmoBox;
        private System.Windows.Forms.ComboBox HFunctionCobmoBox;
        private System.Windows.Forms.Label HFunctionLabel;
        private System.Windows.Forms.Label WFunctionLabel;
        private System.Windows.Forms.Panel panel1;
        private LiveCharts.WinForms.CartesianChart cartesianChart_f_t;
        private LiveCharts.WinForms.CartesianChart cartesianChart_g_t;
        private LiveCharts.WinForms.CartesianChart cartesianChart_h_t;
        private System.Windows.Forms.TextBox q_HTextBox;
        private System.Windows.Forms.Label qforHLabel;
        private System.Windows.Forms.TextBox w_HTextBox;
        private System.Windows.Forms.Label wforHLabel;
        private System.Windows.Forms.TextBox q_WTextBox;
        private System.Windows.Forms.Label qforWLabel;
        private System.Windows.Forms.TextBox w_WTextBox;
        private System.Windows.Forms.Label wforWLabel;
        private OxyPlot.WindowsForms.PlotView plotViewh_t;
    }
}

