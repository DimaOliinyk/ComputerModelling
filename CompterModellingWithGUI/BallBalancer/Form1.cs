using Microsoft.FSharp.Core;
using ModellingLogic;

namespace BallBalancer
{
    public partial class Form_Main : Form
    {
        private double X = 0.0;
        private double Y = 0.0;
        private double Time = 0.0;
        private readonly double timeDelta = 0.1;
        private FSharpFunc<double, double> calcModel;
        private bool _isSlowedDown = false;

        public Form_Main()
        {
            InitializeComponent();
            Timer_Main.Interval = (int)(1000 * timeDelta);
            calcModel = Models.SetUpModel(timeDelta);
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            Timer_Main.Start();
            calcModel = Models.SetUpModel(timeDelta);
            Chart_Main.Series[0].Points.Clear();
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
            Y = calcModel.Invoke(X);
            Time += timeDelta;
            Chart_Main.Series[0].Points.AddXY(Time, Y);
        }

        private static void ChangeLbl(Label lbl, string txt) =>
            lbl.Text = txt;

        private static double LimitInput(double x) =>
            Math.Clamp(x, -20, 20);

        private void Btn_X_Dec_Click(object sender, EventArgs e) =>
            ChangeLbl(Lbl_X, $"{X = LimitInput(--X):F0}°");

        private void Btn_X_Inc_Click(object sender, EventArgs e) =>
            ChangeLbl(Lbl_X, $"{X = LimitInput(++X):F0}°");
    }
}
