
namespace Spring
{
    partial class Spring
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.MassLabel = new System.Windows.Forms.Label();
            this.IntegrationStepTextBox = new System.Windows.Forms.TextBox();
            this.IntegrationStepLabel = new System.Windows.Forms.Label();
            this.InitialSpeedTextBox = new System.Windows.Forms.TextBox();
            this.InitialSpeedLabel = new System.Windows.Forms.Label();
            this.InitialLocationTextBox = new System.Windows.Forms.TextBox();
            this.InitialLocationLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.MassLabel);
            this.panel1.Controls.Add(this.IntegrationStepTextBox);
            this.panel1.Controls.Add(this.IntegrationStepLabel);
            this.panel1.Controls.Add(this.InitialSpeedTextBox);
            this.panel1.Controls.Add(this.InitialSpeedLabel);
            this.panel1.Controls.Add(this.InitialLocationTextBox);
            this.panel1.Controls.Add(this.InitialLocationLabel);
            this.panel1.Location = new System.Drawing.Point(848, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 596);
            this.panel1.TabIndex = 0;
            // 
            // HFunctionLabel
            // 
            this.HFunctionLabel.AutoSize = true;
            this.HFunctionLabel.Location = new System.Drawing.Point(20, 431);
            this.HFunctionLabel.Name = "HFunctionLabel";
            this.HFunctionLabel.Size = new System.Drawing.Size(79, 15);
            this.HFunctionLabel.TabIndex = 20;
            this.HFunctionLabel.Text = "Function: h(t)";
            // 
            // WFunctionLabel
            // 
            this.WFunctionLabel.AutoSize = true;
            this.WFunctionLabel.Location = new System.Drawing.Point(20, 373);
            this.WFunctionLabel.Name = "WFunctionLabel";
            this.WFunctionLabel.Size = new System.Drawing.Size(81, 15);
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
            this.HFunctionCobmoBox.Location = new System.Drawing.Point(20, 449);
            this.HFunctionCobmoBox.Name = "HFunctionCobmoBox";
            this.HFunctionCobmoBox.Size = new System.Drawing.Size(111, 23);
            this.HFunctionCobmoBox.TabIndex = 18;
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
            this.WFunctionCobmoBox.Size = new System.Drawing.Size(111, 23);
            this.WFunctionCobmoBox.TabIndex = 17;
            // 
            // A_HTextBox
            // 
            this.A_HTextBox.Location = new System.Drawing.Point(142, 449);
            this.A_HTextBox.Name = "A_HTextBox";
            this.A_HTextBox.Size = new System.Drawing.Size(29, 23);
            this.A_HTextBox.TabIndex = 16;
            // 
            // AForHLabel
            // 
            this.AForHLabel.AutoSize = true;
            this.AForHLabel.Location = new System.Drawing.Point(142, 431);
            this.AForHLabel.Name = "AForHLabel";
            this.AForHLabel.Size = new System.Drawing.Size(40, 15);
            this.AForHLabel.TabIndex = 15;
            this.AForHLabel.Text = "A: h(t)";
            // 
            // A_WTextBox
            // 
            this.A_WTextBox.Location = new System.Drawing.Point(142, 391);
            this.A_WTextBox.Name = "A_WTextBox";
            this.A_WTextBox.Size = new System.Drawing.Size(29, 23);
            this.A_WTextBox.TabIndex = 14;
            // 
            // AForWLabel
            // 
            this.AForWLabel.AutoSize = true;
            this.AForWLabel.Location = new System.Drawing.Point(142, 373);
            this.AForWLabel.Name = "AForWLabel";
            this.AForWLabel.Size = new System.Drawing.Size(42, 15);
            this.AForWLabel.TabIndex = 13;
            this.AForWLabel.Text = "A: w(t)";
            // 
            // ResilienceTextBox
            // 
            this.ResilienceTextBox.Location = new System.Drawing.Point(20, 309);
            this.ResilienceTextBox.Name = "ResilienceTextBox";
            this.ResilienceTextBox.Size = new System.Drawing.Size(151, 23);
            this.ResilienceTextBox.TabIndex = 12;
            // 
            // ResilienceLabel
            // 
            this.ResilienceLabel.AutoSize = true;
            this.ResilienceLabel.Location = new System.Drawing.Point(20, 291);
            this.ResilienceLabel.Name = "ResilienceLabel";
            this.ResilienceLabel.Size = new System.Drawing.Size(71, 15);
            this.ResilienceLabel.TabIndex = 11;
            this.ResilienceLabel.Text = "Resilience: c";
            // 
            // TenacityRateTextBox
            // 
            this.TenacityRateTextBox.Location = new System.Drawing.Point(20, 252);
            this.TenacityRateTextBox.Name = "TenacityRateTextBox";
            this.TenacityRateTextBox.Size = new System.Drawing.Size(151, 23);
            this.TenacityRateTextBox.TabIndex = 10;
            // 
            // TenacityRateLabel
            // 
            this.TenacityRateLabel.AutoSize = true;
            this.TenacityRateLabel.Location = new System.Drawing.Point(20, 234);
            this.TenacityRateLabel.Name = "TenacityRateLabel";
            this.TenacityRateLabel.Size = new System.Drawing.Size(88, 15);
            this.TenacityRateLabel.TabIndex = 9;
            this.TenacityRateLabel.Text = "Tenacity Rate: k";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(20, 196);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 23);
            this.textBox2.TabIndex = 8;
            // 
            // MassLabel
            // 
            this.MassLabel.AutoSize = true;
            this.MassLabel.Location = new System.Drawing.Point(20, 178);
            this.MassLabel.Name = "MassLabel";
            this.MassLabel.Size = new System.Drawing.Size(51, 15);
            this.MassLabel.TabIndex = 7;
            this.MassLabel.Text = "Mass: m";
            // 
            // IntegrationStepTextBox
            // 
            this.IntegrationStepTextBox.Location = new System.Drawing.Point(20, 144);
            this.IntegrationStepTextBox.Name = "IntegrationStepTextBox";
            this.IntegrationStepTextBox.Size = new System.Drawing.Size(151, 23);
            this.IntegrationStepTextBox.TabIndex = 6;
            // 
            // IntegrationStepLabel
            // 
            this.IntegrationStepLabel.AutoSize = true;
            this.IntegrationStepLabel.Location = new System.Drawing.Point(20, 126);
            this.IntegrationStepLabel.Name = "IntegrationStepLabel";
            this.IntegrationStepLabel.Size = new System.Drawing.Size(128, 15);
            this.IntegrationStepLabel.TabIndex = 5;
            this.IntegrationStepLabel.Text = "Integration Step (delta)";
            // 
            // InitialSpeedTextBox
            // 
            this.InitialSpeedTextBox.Location = new System.Drawing.Point(20, 91);
            this.InitialSpeedTextBox.Name = "InitialSpeedTextBox";
            this.InitialSpeedTextBox.Size = new System.Drawing.Size(151, 23);
            this.InitialSpeedTextBox.TabIndex = 4;
            // 
            // InitialSpeedLabel
            // 
            this.InitialSpeedLabel.AutoSize = true;
            this.InitialSpeedLabel.Location = new System.Drawing.Point(20, 73);
            this.InitialSpeedLabel.Name = "InitialSpeedLabel";
            this.InitialSpeedLabel.Size = new System.Drawing.Size(97, 15);
            this.InitialSpeedLabel.TabIndex = 3;
            this.InitialSpeedLabel.Text = "Initial Speed: v(0)";
            // 
            // InitialLocationTextBox
            // 
            this.InitialLocationTextBox.Location = new System.Drawing.Point(20, 38);
            this.InitialLocationTextBox.Name = "InitialLocationTextBox";
            this.InitialLocationTextBox.Size = new System.Drawing.Size(151, 23);
            this.InitialLocationTextBox.TabIndex = 2;
            // 
            // InitialLocationLabel
            // 
            this.InitialLocationLabel.AutoSize = true;
            this.InitialLocationLabel.Location = new System.Drawing.Point(20, 20);
            this.InitialLocationLabel.Name = "InitialLocationLabel";
            this.InitialLocationLabel.Size = new System.Drawing.Size(111, 15);
            this.InitialLocationLabel.TabIndex = 1;
            this.InitialLocationLabel.Text = "Initial Location: x(0)";
            // 
            // Spring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 620);
            this.Controls.Add(this.panel1);
            this.Name = "Spring";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ResilienceTextBox;
        private System.Windows.Forms.Label ResilienceLabel;
        private System.Windows.Forms.TextBox TenacityRateTextBox;
        private System.Windows.Forms.Label TenacityRateLabel;
        private System.Windows.Forms.TextBox textBox2;
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
    }
}

