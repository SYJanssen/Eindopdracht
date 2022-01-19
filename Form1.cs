using MLDE3Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Eindopdracht
{
    public partial class Form1 : Form
    {
        public double metal;
        public double profile;
        public double heatconduction;
        public double sizex;
        public double sizey;
        public double intervalx;
        public double intervaly;
        public double tempstart;
        public double tempend;
        private CDE3 _DE;

        private CDE3 dE
        {
            get
            {
                if (_DE == null)
                {
                    _DE = new CDE3();
                }
                return _DE;
            }
        }

        List<Double> input = new List<Double>{ double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity,
                                               double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity,
                                               double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity};

        private System.Timers.Timer _timer;
        private DateTime _startTime;

        public Form1()
        {
            Start_Timer();
            InitializeComponent();
            UpdateCDE(input);
        }

        public bool Check_Input(List<double> inp)
        {
            foreach (double val in inp)
            {
                if (val == double.PositiveInfinity) { return false; } { continue; }
            }
            return true;
        }

        private void UpdateCDE(List<double> inp)
        {
            //bool cond = (Check_Input(inp))? true: false;
            double me = 0;
            double l1 = 10;
            double l2 = 10;
            double t1 = 1;
            double t2 = 2;
            double prof = 0;
            double n = 10;
            double m = 10;
            double con = 1;
            object w = dE.DE(me,l1,l2,t1,t2,prof,n,m,con);
            double[,] result = (double[,])w;
            int rowNum = 1;
            int colNum = 1;
            //Enumerable.Range(0, result.GetLength(1)).Select(x => result[rowNum, x]).ToArray(); //All from row
            //Enumerable.Range(0, result.GetLength(1)).Select(x => result[x, colNum]).ToArray(); //All from col
        }


        public void Start_Timer()
        {
            _startTime = DateTime.Now;
            _timer = new System.Timers.Timer(1000 * 1); // 10 seconds
            _timer.Elapsed += timer_Elapsed;
            _timer.Enabled = true;
        }

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            TimeSpan timeSinceStart = DateTime.Now - _startTime;
        }

        private void Metal_SelectedValueChanged(object sender, EventArgs e)
        {
            metal = Metal.SelectedIndex;
            input[0] = metal;
            UpdateCDE(input);
        }

        private void Profile_SelectedValueChanged(object sender, EventArgs e)
        {
            profile = Profile.SelectedIndex;
            input[1] = profile;
            UpdateCDE(input);
        }

        private void HeatConduction_ValueChanged(object sender, EventArgs e)
        {
            heatconduction = HeatConduction.Value;
            input[2] = heatconduction;
            UpdateCDE(input);
        }

        private void SizeX_TextChanged(object sender, EventArgs e)
        {
            if (SizeX.Text == null || SizeX.Text == String.Empty) { sizex = double.PositiveInfinity; } else { sizex = Convert.ToDouble(SizeX.Text); }
            input[3] = sizex;
            UpdateCDE(input);
        }

        private void SizeY_TextChanged(object sender, EventArgs e)
        {
            if (SizeY.Text == null || SizeY.Text == String.Empty) { sizey = double.PositiveInfinity; } else { sizey = Convert.ToDouble(SizeY.Text); }
            input[4] = sizey;
            UpdateCDE(input);
        }

        private void IntervalX_TextChanged(object sender, EventArgs e)
        {
            if (IntervalX.Text == null || IntervalX.Text == String.Empty) { intervalx = double.PositiveInfinity; } else { intervalx = Convert.ToDouble(IntervalX.Text); }
            input[5] = intervalx;
            UpdateCDE(input);
        }

        private void IntervalY_TextChanged(object sender, EventArgs e)
        {
            if (IntervalY.Text == null || IntervalY.Text == String.Empty) { intervaly = double.PositiveInfinity; } else { intervaly = Convert.ToDouble(IntervalY.Text); }
            input[6] = intervaly;
            UpdateCDE(input);
        }

        private void TempStart_TextChanged(object sender, EventArgs e)
        {
            if (TempStart.Text == null || TempStart.Text == String.Empty) { tempstart = double.PositiveInfinity; } else { tempstart = Convert.ToDouble(TempStart.Text); }
            input[7] = tempstart;
            UpdateCDE(input);
        }

        private void TempEnd_TextChanged(object sender, EventArgs e)
        {
            if (TempEnd.Text == null || TempEnd.Text == String.Empty) { tempend = double.PositiveInfinity; } else { tempend = Convert.ToDouble(TempEnd.Text); }
            input[8] = tempend;
            UpdateCDE(input);
        }
    }
}
