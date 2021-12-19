using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyncVsAsyncBouncyBox
{
    public partial class BouncyBox : TextBox
    {
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

        private System.Windows.Forms.Timer _redrawTimer;
        private System.Windows.Forms.Timer _oneSecondTimer;
        private System.Windows.Forms.Timer _variableSecondTimer;
        private int _elapsed;
        private int _xDirection;
        private int _yDirection;

        public BouncyBox() : base ()
        {
            InitializeComponent();
            _redrawTimer = new System.Windows.Forms.Timer()
            {
                Interval = 10,
            };
            _redrawTimer.Tick += _redrawTimer_Tick;
            _oneSecondTimer = new System.Windows.Forms.Timer()
            {
                Interval = 1000,
            }; 
            _variableSecondTimer = new System.Windows.Forms.Timer()
            {
                Interval = 2000,
            };
            _variableSecondTimer.Tick += __variableSecondTimer_Tick;
            _oneSecondTimer.Tick += _oneSecondTimer_Tick;
            _xDirection = 1;//Initialize moving to the right
            _yDirection = 1;//Initialize moving down
        }

        public void Start()
        {
            _redrawTimer.Start();
            _oneSecondTimer.Start();
            _variableSecondTimer.Start();
        }
        public void Stop()
        {
            _redrawTimer.Stop();
            _oneSecondTimer.Stop();
            _variableSecondTimer.Stop();
        }

        public void Reset()
        {
            _elapsed = 0;
            Location = new Point(0, 0);
        }

        private void __variableSecondTimer_Tick(object? sender, EventArgs e)
        {
            OnTick?.Invoke(this);
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
            this.Text = $"{_elapsed++}";
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public delegate void BouncyBoxEvent(BouncyBox bouncyBox);
    }
}
