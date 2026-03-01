namespace CompterModellingWithGUI;

using Microsoft.FSharp.Core;
using ModellingLogic;

public partial class MainForm : Form
{
    private double X1 = 0.0;
    private double X2 = 0.0;
    private double Y = 0.0;
    private double Time = 0.0;
    private readonly double timeDelta = 0.1;
    private FSharpFunc<double, double> calcModel;
    private bool _isSpedUp = false;

    public MainForm()
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

    private void Timer_Main_Tick(object sender, EventArgs e)
    {
        Y = calcModel.Invoke(X1-X2);
        Time += timeDelta;
        Chart_Main.Series[0].Points.AddXY(Time, Y);
        ChangeLbl(Lbl_Y, $"T: {Y:F2}");
    }

    private void Btn_ChangeSpeed_Click(object sender, EventArgs e)
    {
        _isSpedUp = !_isSpedUp;
        Btn_ChangeSpeed.Text = (_isSpedUp) ? "x1" : "x10";

        if (_isSpedUp)
            Timer_Main.Interval /= 10;
        else
            Timer_Main.Interval *= 10;
    }

    private void Btn_X1_Inc_Click(object sender, EventArgs e) =>
        ChangeLbl(Lbl_X1, $"{X1 = LimitInput(++X1):F0}");

    private void Btn_X1_Dec_Click(object sender, EventArgs e) =>
        ChangeLbl(Lbl_X1, $"{X1 = LimitInput(--X1):F0}");

    private void Btn_X2_Inc_Click(object sender, EventArgs e) =>
        ChangeLbl(Lbl_X2, $"{X2 = LimitInput(++X2):F0}");

    private void Btn_X2_Dec_Click(object sender, EventArgs e) =>
        ChangeLbl(Lbl_X2, $"{X2 = LimitInput(--X2):F0}");

    private static void ChangeLbl(Label lbl, string txt) => 
        lbl.Text = txt;

    private static double LimitInput(double x) =>
        Math.Clamp(x, 0, 10);
}
