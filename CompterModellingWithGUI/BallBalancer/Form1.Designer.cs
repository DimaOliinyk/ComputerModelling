namespace BallBalancer
{
    partial class Form_Main
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            Chart_Main = new System.Windows.Forms.DataVisualization.Charting.Chart();
            Btn_X_Dec = new Button();
            Btn_X_Inc = new Button();
            Lbl_X = new Label();
            Btn_Speed = new Button();
            Btn_Start = new Button();
            Btn_Stop = new Button();
            Timer_Main = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Chart_Main).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Chart_Main
            // 
            Chart_Main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            Chart_Main.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            Chart_Main.Legends.Add(legend1);
            Chart_Main.Location = new Point(0, 214);
            Chart_Main.Name = "Chart_Main";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "L";
            series1.LegendToolTip = "Ball distance";
            series1.Name = "Series1";
            Chart_Main.Series.Add(series1);
            Chart_Main.Size = new Size(800, 236);
            Chart_Main.TabIndex = 0;
            Chart_Main.Text = "chart1";
            // 
            // Btn_X_Dec
            // 
            Btn_X_Dec.Location = new Point(330, 179);
            Btn_X_Dec.Name = "Btn_X_Dec";
            Btn_X_Dec.Size = new Size(29, 29);
            Btn_X_Dec.TabIndex = 1;
            Btn_X_Dec.Text = "<";
            Btn_X_Dec.UseVisualStyleBackColor = true;
            Btn_X_Dec.Click += Btn_X_Dec_Click;
            // 
            // Btn_X_Inc
            // 
            Btn_X_Inc.Location = new Point(421, 179);
            Btn_X_Inc.Name = "Btn_X_Inc";
            Btn_X_Inc.Size = new Size(29, 29);
            Btn_X_Inc.TabIndex = 2;
            Btn_X_Inc.Text = ">";
            Btn_X_Inc.UseVisualStyleBackColor = true;
            Btn_X_Inc.Click += Btn_X_Inc_Click;
            // 
            // Lbl_X
            // 
            Lbl_X.AutoSize = true;
            Lbl_X.Location = new Point(374, 183);
            Lbl_X.Name = "Lbl_X";
            Lbl_X.Size = new Size(23, 20);
            Lbl_X.TabIndex = 3;
            Lbl_X.Text = "0°";
            // 
            // Btn_Speed
            // 
            Btn_Speed.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Speed.Location = new Point(629, 12);
            Btn_Speed.Name = "Btn_Speed";
            Btn_Speed.Size = new Size(59, 64);
            Btn_Speed.TabIndex = 4;
            Btn_Speed.Text = "x0.5";
            Btn_Speed.UseVisualStyleBackColor = true;
            Btn_Speed.Click += Btn_Speed_Click;
            // 
            // Btn_Start
            // 
            Btn_Start.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Start.Location = new Point(694, 12);
            Btn_Start.Name = "Btn_Start";
            Btn_Start.Size = new Size(94, 29);
            Btn_Start.TabIndex = 5;
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
            Btn_Stop.TabIndex = 6;
            Btn_Stop.Text = "Stop";
            Btn_Stop.UseVisualStyleBackColor = true;
            Btn_Stop.Click += Btn_Stop_Click;
            // 
            // Timer_Main
            // 
            Timer_Main.Tick += Timer_Main_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.StandImage;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(623, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(Btn_Stop);
            Controls.Add(Btn_Start);
            Controls.Add(Btn_Speed);
            Controls.Add(Lbl_X);
            Controls.Add(Btn_X_Inc);
            Controls.Add(Btn_X_Dec);
            Controls.Add(Chart_Main);
            Name = "Form_Main";
            Text = "Ball Balancer Model";
            ((System.ComponentModel.ISupportInitialize)Chart_Main).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Main;
        private Button Btn_X_Dec;
        private Button Btn_X_Inc;
        private Label Lbl_X;
        private Button Btn_Speed;
        private Button Btn_Start;
        private Button Btn_Stop;
        private System.Windows.Forms.Timer Timer_Main;
        private PictureBox pictureBox1;
    }
}
