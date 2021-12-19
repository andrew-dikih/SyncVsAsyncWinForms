using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyncVsAsyncBouncyBox;

public partial class BouncyBox : TextBox
{
    private const int _tenthSecond = 100;
    public event BouncyBoxEvent? OnTick;
    public int Interval
    {
        get
        {
            return _variableSecondTimer.Interval;
        }
        set
        {
            _variableSecondTimer.Interval = value;
        }
    }

    public string CustomText { get; set; }

    private System.Windows.Forms.Timer _redrawTimer;
    private System.Windows.Forms.Timer _tenthSecondTimer;
    private System.Windows.Forms.Timer _variableSecondTimer;
    private Stopwatch _stopwatch;
    private int _xDirection;
    private int _yDirection;

    private double _elapsed => _stopwatch.ElapsedMilliseconds/1000d;

    public BouncyBox() : base()
    {
        InitializeComponent();
        _redrawTimer = new System.Windows.Forms.Timer()
        {
            Interval = 10,
        };
        _redrawTimer.Tick += _redrawTimer_Tick;
        _tenthSecondTimer = new System.Windows.Forms.Timer()
        {
            Interval = _tenthSecond,
        };
        _variableSecondTimer = new System.Windows.Forms.Timer()
        {
            Interval = 500,
        };
        _variableSecondTimer.Tick += __variableSecondTimer_Tick;
        _tenthSecondTimer.Tick += _oneSecondTimer_Tick;
        _stopwatch = new Stopwatch();
        _xDirection = 1;//Initialize moving to the right
        _yDirection = 1;//Initialize moving down
        CustomText = "";
    }

    public void Start()
    {
        _redrawTimer.Start();
        _tenthSecondTimer.Start();
        _variableSecondTimer.Start();
        _stopwatch.Start();
    }
    public void Stop()
    {
        _redrawTimer.Stop();
        _tenthSecondTimer.Stop();
        _variableSecondTimer.Stop();
        _stopwatch.Stop();
        _stopwatch.Reset();
    }

    public void Reset()
    {
        Location = new Point(0, 0);
        Stop();
        Start();
    }

    private void __variableSecondTimer_Tick(object? sender, EventArgs e)
    {
        OnTick?.Invoke(this,_elapsed);
    }

    private void _redrawTimer_Tick(object? sender, EventArgs e)
    {
        this.Location = GetNextPosition();
    }

    private Point GetNextPosition()
    {
        SetDirection();
        return new Point(Location.X + _xDirection, Location.Y + _yDirection);
    }

    private void SetDirection()
    {
        _xDirection = GetDirection(_xDirection, Location.X, Width, Parent.Width);
        _yDirection = GetDirection(_yDirection, Location.Y, Height, Parent.Height);
    }

    private int GetDirection(int currentDirection, int currentPos, int dimension, int max)
    {
        if (currentPos + currentDirection < 0)
        {
            return 1;
        }
        else if (currentPos + dimension + currentDirection > max)
        {
            return -1;
        }
        return currentDirection;
    }

    private void _oneSecondTimer_Tick(object? sender, EventArgs e)
    {
        this.Text = $"{_elapsed.ToString("F1")}\r\n{CustomText}";
    }

    protected override void OnPaint(PaintEventArgs pe)
    {
        base.OnPaint(pe);
    }

    public delegate void BouncyBoxEvent(BouncyBox bouncyBox,double elapsed);
}
