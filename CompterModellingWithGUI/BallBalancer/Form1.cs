using Microsoft.FSharp.Core;
using ModellingLogic;
using System.Windows.Forms.DataVisualization.Charting;
using static ModellingLogic.Models;

namespace BallBalancer
{
    public partial class Form_Main : Form
    {
        private double _x = 0.0;
        private double X 
        {
            get => _x; 
            set 
            { 
                _x = value; 
                Lbl_X.Text = $"{X:F4}°"; 
            } 
        }
        private double Y = 0.6;
        private double Time = 0.0;
        private readonly double setpoint = 0.0;
        private readonly double timeDelta = 0.1;
        private FSharpFunc<double, double> calcModel;
        private FSharpFunc<double, double> calcAngleController;
        private FSharpFunc<double, double> absinterr;
        private FSharpFunc<double, double> sqrinterr;
        private readonly PIDparams _pidParams = new(1, 0, 1.5);
        private bool _isSlowedDown = false;
        private bool _isAutoScaled = false;
        private bool _isAutoControl = true;

        public Form_Main()
        {
            InitializeComponent();
            Timer_Main.Interval = (int)(1000 * timeDelta);
            calcModel = Models.SetUpModel(timeDelta);

            calcAngleController = Models.SetUpController(setpoint, timeDelta, _pidParams);
            absinterr = Blocks.Integrate(timeDelta);
            sqrinterr = Blocks.Integrate(timeDelta);
            Chart_Main.Series.Add("mainObject");
            Chart_Main.Series.Add("setpoint");

            Chart_Main.Series["mainObject"].ChartType = SeriesChartType.Line;
            Chart_Main.Series["setpoint"].ChartType = SeriesChartType.Line;
            Chart_Main.Series["setpoint"].BorderDashStyle = ChartDashStyle.Dash;

            Btn_X_Dec.Enabled = !_isAutoControl;
            Btn_X_Inc.Enabled = !_isAutoControl;
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            Timer_Main.Start();
            calcModel = Models.SetUpModel(timeDelta);
            calcAngleController = Models.SetUpController(setpoint, timeDelta, _pidParams);

            absinterr = Blocks.Integrate(timeDelta);
            sqrinterr = Blocks.Integrate(timeDelta);
            Chart_Main.Series["mainObject"].Points.Clear();
            Chart_Main.Series["setpoint"].Points.Clear();
        }

        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            Timer_Main.Stop();
        }

        private void Btn_Speed_Click(object sender, EventArgs e)
        {
            _isSlowedDown = !_isSlowedDown;
            Btn_Speed.Text = (_isSlowedDown) ? "x1" : "x0.5";

            if (_isSlowedDown)
                Timer_Main.Interval *= 2;
            else
                Timer_Main.Interval /= 2;
        }

        private void Timer_Main_Tick(object sender, EventArgs e)
        {
            if (_isAutoControl) 
                X = calcAngleController.Invoke(Y);
            else
                calcAngleController.Invoke(Y);
            Y = calcModel.Invoke(X);


            Time += timeDelta;
            Chart_Main.Series["mainObject"].Points.AddXY(Time, Y + 0.5);
            Chart_Main.Series["setpoint"].Points.AddXY(Time, setpoint + 0.5);

            SetAxisLimit();

            ChangeLbl(Lbl_AbsIntErr, $"IAE: {absinterr.Invoke(Math.Abs(setpoint - Y)):F5}");
            ChangeLbl(Lbl_SqrIntErr, $"ISE: {sqrinterr.Invoke(Math.Pow(setpoint - Y, 2)):F5}");
        }

        private static void ChangeLbl(Label lbl, string txt) =>
            lbl.Text = txt;

        private static double LimitInput(double x) =>
            Math.Clamp(x, -20, 20);

        private void Btn_X_Dec_Click(object sender, EventArgs e) =>
            X = LimitInput(--X);

        private void Btn_X_Inc_Click(object sender, EventArgs e) =>
            X = LimitInput(++X);

        private void Lbl_AxesLimit_Click(object sender, EventArgs e)
        {
            _isAutoScaled = !_isAutoScaled;
            Lbl_AxesLimit.Text = _isAutoScaled ? "Auto" : "Fixed";
        }

        private void SetAxisLimit()
        {
            if (_isAutoScaled)
            {
                Chart_Main.ChartAreas[0].AxisY.Minimum =
                Chart_Main
                    .Series["mainObject"]
                    .Points
                    .SelectMany(x => x.YValues)
                    .TakeLast(10)
                    .Append(0.5)
                    .Min() - 0.02;
                Chart_Main.ChartAreas[0].AxisY.Maximum =
                    Chart_Main
                        .Series["mainObject"]
                        .Points
                        .SelectMany(x => x.YValues)
                        .TakeLast(10)
                        .Append(0.5)
                        .Max() + 0.02;
            }
            else
            {
                Chart_Main.ChartAreas[0].AxisY.Minimum = 0.46;
                Chart_Main.ChartAreas[0].AxisY.Maximum = 0.54;
            }
        }

        private void Btn_ManualAutomaticControl_Click(object sender, EventArgs e)
        {
            _isAutoControl = !_isAutoControl;
            Btn_ManualAutomaticControl.Text = 
                (_isAutoControl) ? "Automatic" : "Manual";

            Btn_X_Dec.Enabled = !_isAutoControl;
            Btn_X_Inc.Enabled = !_isAutoControl;
        }
    }
}
