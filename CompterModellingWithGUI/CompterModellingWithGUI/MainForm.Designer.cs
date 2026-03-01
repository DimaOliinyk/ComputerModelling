namespace CompterModellingWithGUI
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            Btn_Start = new Button();
            Btn_Stop = new Button();
            Timer_Main = new System.Windows.Forms.Timer(components);
            Lbl_Y = new Label();
            Btn_X_Dec = new Button();
            Btn_X_Inc = new Button();
            this.Lbl_X1 = new Label();
            Chart_Main = new System.Windows.Forms.DataVisualization.Charting.Chart();
            Btn_ChangeSpeed = new Button();
            Btn_X2_Dec = new Button();
            Btn_X2_Inc = new Button();
            Lbl_X2 = new Label();
            ((System.ComponentModel.ISupportInitialize)Chart_Main).BeginInit();
            SuspendLayout();
            // 
            // Btn_Start
            // 
            Btn_Start.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Start.Location = new Point(694, 12);
            Btn_Start.Name = "Btn_Start";
            Btn_Start.Size = new Size(94, 29);
            Btn_Start.TabIndex = 0;
            Btn_Start.Text = "Start";
            Btn_Start.UseVisualStyleBackColor = true;
            Btn_Start.Click += Btn_Start_Click;
            // 
            // Btn_Stop
            // 
            Btn_Stop.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Stop.Location = new Point(694, 47);
            Btn_Stop.Name = "Btn_Stop";
            Btn_Stop.Size = new Size(94, 29);
            Btn_Stop.TabIndex = 1;
            Btn_Stop.Text = "Stop";
            Btn_Stop.UseVisualStyleBackColor = true;
            Btn_Stop.Click += Btn_Stop_Click;
            // 
            // Timer_Main
            // 
            Timer_Main.Interval = 1000;
            Timer_Main.Tick += Timer_Main_Tick;
            // 
            // Lbl_Y
            // 
            Lbl_Y.AutoSize = true;
            Lbl_Y.Location = new Point(436, 56);
            Lbl_Y.Name = "Lbl_Y";
            Lbl_Y.Size = new Size(43, 20);
            Lbl_Y.TabIndex = 2;
            Lbl_Y.Text = "T: 0.0";
            // 
            // Btn_X_Dec
            // 
            Btn_X_Dec.Location = new Point(218, 12);
            Btn_X_Dec.Name = "Btn_X_Dec";
            Btn_X_Dec.Size = new Size(37, 29);
            Btn_X_Dec.TabIndex = 3;
            Btn_X_Dec.Text = "<";
            Btn_X_Dec.UseVisualStyleBackColor = true;
            Btn_X_Dec.Click += Btn_X1_Dec_Click;
            // 
            // Btn_X_Inc
            // 
            Btn_X_Inc.Location = new Point(327, 12);
            Btn_X_Inc.Name = "Btn_X_Inc";
            Btn_X_Inc.Size = new Size(40, 29);
            Btn_X_Inc.TabIndex = 4;
            Btn_X_Inc.Text = ">";
            Btn_X_Inc.UseVisualStyleBackColor = true;
            Btn_X_Inc.Click += Btn_X1_Inc_Click;
            // 
            // Lbl_X1
            // 
            this.Lbl_X1.AutoSize = true;
            this.Lbl_X1.Location = new Point(261, 16);
            this.Lbl_X1.Name = "Lbl_X1";
            this.Lbl_X1.Size = new Size(28, 20);
            this.Lbl_X1.TabIndex = 5;
            this.Lbl_X1.Text = "0.0";
            // 
            // Chart_Main
            // 
            Chart_Main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea2.Name = "ChartArea1";
            Chart_Main.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            Chart_Main.Legends.Add(legend2);
            Chart_Main.Location = new Point(12, 82);
            Chart_Main.Name = "Chart_Main";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.LegendText = "T";
            series2.LegendToolTip = "BoilerTemperature";
            series2.Name = "TSeries";
            Chart_Main.Series.Add(series2);
            Chart_Main.Size = new Size(776, 356);
            Chart_Main.TabIndex = 6;
            Chart_Main.Text = "chart1";
            // 
            // Btn_ChangeSpeed
            // 
            Btn_ChangeSpeed.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_ChangeSpeed.Location = new Point(647, 12);
            Btn_ChangeSpeed.Name = "Btn_ChangeSpeed";
            Btn_ChangeSpeed.Size = new Size(41, 60);
            Btn_ChangeSpeed.TabIndex = 7;
            Btn_ChangeSpeed.Text = "x10";
            Btn_ChangeSpeed.UseVisualStyleBackColor = true;
            Btn_ChangeSpeed.Click += Btn_ChangeSpeed_Click;
            // 
            // Btn_X2_Dec
            // 
            Btn_X2_Dec.Location = new Point(218, 47);
            Btn_X2_Dec.Name = "Btn_X2_Dec";
            Btn_X2_Dec.Size = new Size(37, 29);
            Btn_X2_Dec.TabIndex = 8;
            Btn_X2_Dec.Text = "<";
            Btn_X2_Dec.UseVisualStyleBackColor = true;
            Btn_X2_Dec.Click += Btn_X2_Dec_Click;
            // 
            // Btn_X2_Inc
            // 
            Btn_X2_Inc.Location = new Point(327, 48);
            Btn_X2_Inc.Name = "Btn_X2_Inc";
            Btn_X2_Inc.Size = new Size(40, 29);
            Btn_X2_Inc.TabIndex = 9;
            Btn_X2_Inc.Text = ">";
            Btn_X2_Inc.UseVisualStyleBackColor = true;
            Btn_X2_Inc.Click += Btn_X2_Inc_Click;
            // 
            // Lbl_X2
            // 
            Lbl_X2.AutoSize = true;
            Lbl_X2.Location = new Point(261, 52);
            Lbl_X2.Name = "Lbl_X2";
            Lbl_X2.Size = new Size(28, 20);
            Lbl_X2.TabIndex = 10;
            Lbl_X2.Text = "0.0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Lbl_X2);
            Controls.Add(Btn_X2_Inc);
            Controls.Add(Btn_X2_Dec);
            Controls.Add(Btn_ChangeSpeed);
            Controls.Add(Chart_Main);
            Controls.Add(this.Lbl_X1);
            Controls.Add(Btn_X_Inc);
            Controls.Add(Btn_X_Dec);
            Controls.Add(Lbl_Y);
            Controls.Add(Btn_Stop);
            Controls.Add(Btn_Start);
            MinimumSize = new Size(818, 497);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Chart_Main).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Start;
        private Button Btn_Stop;
        private System.Windows.Forms.Timer Timer_Main;
        private Label Lbl_Y;
        private Button Btn_X_Dec;
        private Button Btn_X_Inc;
        private Label Lbl_X1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Main;
        private Button Btn_ChangeSpeed;
        private Button Btn_X2_Dec;
        private Button Btn_X2_Inc;
        private Label Lbl_X2;
    }
}
