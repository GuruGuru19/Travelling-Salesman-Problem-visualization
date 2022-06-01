using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellingSalesmanProblemCpppp
{
    class Point
    {
        public double xValue { get; set; }
        public double yValue { get; set; }
        private string title;

        public Point(double x = 0, double y = 0, string title = "")
        {
            this.xValue = x;
            this.yValue = y;
            this.title = title;
        }

        #region geters and seters
        public double GetX()
        {
            return this.xValue;
        }

        public void SetX(double x = 0)
        {
            this.xValue = x;
        }

        public double GetY()
        {
            return this.yValue;
        }

        public void SetY(double y = 0)
        {
            this.yValue = y;
        }

        public string GetTitle()
        {
            return this.title;
        }

        public void SetTitle(string newTitle)
        {
            this.title = newTitle;
        }

        #endregion

        public double GetDistanceToPoint(Point point)
        {
            return Math.Sqrt(Math.Pow(this.xValue - point.xValue, 2) + Math.Pow(this.yValue - point.yValue, 2));
        }

        public override string ToString()
        {
            return String.Format("({0},{1}) {2}", this.xValue, this.yValue, this.title);
        }
    }
}
