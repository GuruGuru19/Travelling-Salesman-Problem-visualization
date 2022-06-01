using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TravellingSalesmanProblemCpppp
{
    public partial class Form1 : Form
    {
        static Random RANDOM = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void AddPoint(double x, double y)
        {
            Map.AddPoint(new Point(x, y));
            Grid.Series[0].Points.Clear();
            foreach (Point p in Map.GetPoints())
            {
                Grid.Series[0].Points.AddXY(p.GetX(), p.GetY());
            }
            //pointsDataDisplay.DataSource = Map.GetPoints();
            textBox1.Text = "";
            textBox2.Text = "";
            ClearButton.Enabled = true;
            if (Map.GetCount() > 2)
            {
                SolutionButton.Enabled = true;
                ApproximationButton.Enabled = true;
            }
            else
            {
                SolutionButton.Enabled = false;
                ApproximationButton.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Map.Start(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            AddPointButton.Enabled = (textBox1.Text != "" && textBox2.Text != "");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            AddPointButton.Enabled = (textBox1.Text != "" && textBox2.Text != "");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Grid.Series[0].Points.Clear();
            Grid.Series[1].Points.Clear();
            Grid.Series[2].Points.Clear();
            Map.DeleteAllPoints();
            ClearButton.Enabled = false;
            SolutionButton.Enabled = false;
            ApproximationButton.Enabled = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            numericUpDownRandomMinX.Enabled = true;
            numericUpDownRandomMaxX.Enabled = true;
            numericUpDownRandomMinY.Enabled = true;
            numericUpDownRandomMaxY.Enabled = true;
            buttonRandomPoint.Enabled = numericUpDownRandomMaxX.Value > numericUpDownRandomMinX.Value && numericUpDownRandomMaxY.Value > numericUpDownRandomMinY.Value;
            solutionDisplay.Text = "The best route's length is:";
        }

        private void AddPointButton_Click(object sender, EventArgs e)
        {
            AddPoint(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
        }

        private void SolutionButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            SolutionButton.Enabled = false;
            ApproximationButton.Enabled = false;
            ClearButton.Enabled = false;
            numericUpDownRandomMinX.Enabled = false;
            numericUpDownRandomMaxX.Enabled = false;
            numericUpDownRandomMinY.Enabled = false;
            numericUpDownRandomMaxY.Enabled = false;
            buttonRandomPoint.Enabled = false;
            Solution();
            //Thread solutionThread = new Thread(Solution);
            //solutionThread.Start();
        }

        private void Solution()
        {
            Route solution = Map.CalculateSolution();
            double dis = solution.GetLength();
            solutionDisplay.Text = string.Format("The best route's length is:\n {0:0.###}", dis);
            ApproximationButton.Enabled = true;
            ClearButton.Enabled = true;
        }

        private void ApproximationButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            SolutionButton.Enabled = false;
            ApproximationButton.Enabled = false;
            ClearButton.Enabled = false;
            numericUpDownRandomMinX.Enabled = false;
            numericUpDownRandomMaxX.Enabled = false;
            numericUpDownRandomMinY.Enabled = false;
            numericUpDownRandomMaxY.Enabled = false;
            buttonRandomPoint.Enabled = false;
            Approximation();
            //Thread approximationThread = new Thread(Approximation);
            //approximationThread.Start();
        }

        private void Approximation()
        {
            Route approximation = Map.CalculateApproximation();
            double dis = approximation.GetLength();
            solutionDisplay.Text = string.Format("The best route's length is:\n {0:0.###}", dis);
            SolutionButton.Enabled = true;
            ClearButton.Enabled = true;
        }

        private void DelayMs_ValueChanged(object sender, EventArgs e)
        {
            Map.delay = Decimal.ToInt32(DelayMs.Value);
        }

        private void buttonRandomPoint_Click(object sender, EventArgs e)
        {
            double x = RANDOM.NextDouble() + RANDOM.Next(Decimal.ToInt32(numericUpDownRandomMinX.Value), Decimal.ToInt32(numericUpDownRandomMaxX.Value));
            double y = RANDOM.NextDouble() + RANDOM.Next(Decimal.ToInt32(numericUpDownRandomMinY.Value), Decimal.ToInt32(numericUpDownRandomMaxY.Value));
            AddPoint(x,y);
        }

        private void numericUpDownRandomMinX_ValueChanged(object sender, EventArgs e)
        {
            buttonRandomPoint.Enabled = numericUpDownRandomMaxX.Value > numericUpDownRandomMinX.Value && numericUpDownRandomMaxY.Value > numericUpDownRandomMinY.Value;
        }

        private void numericUpDownRandomMaxX_ValueChanged(object sender, EventArgs e)
        {
            buttonRandomPoint.Enabled = numericUpDownRandomMaxX.Value > numericUpDownRandomMinX.Value && numericUpDownRandomMaxY.Value > numericUpDownRandomMinY.Value;
        }

        private void numericUpDownRandomMinY_ValueChanged(object sender, EventArgs e)
        {
            buttonRandomPoint.Enabled = numericUpDownRandomMaxX.Value > numericUpDownRandomMinX.Value && numericUpDownRandomMaxY.Value > numericUpDownRandomMinY.Value;
        }

        private void numericUpDownRandomMaxY_ValueChanged(object sender, EventArgs e)
        {
            buttonRandomPoint.Enabled = numericUpDownRandomMaxX.Value > numericUpDownRandomMinX.Value && numericUpDownRandomMaxY.Value > numericUpDownRandomMinY.Value;
        }
    }
}
