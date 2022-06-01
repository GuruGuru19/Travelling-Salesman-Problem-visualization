using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellingSalesmanProblemCpppp
{
    class Route
    {
        private double distance;
        public List<Point> points;

        public Route(int length)
        {
            this.points = new List<Point>(length);
        }

        public Route(Route r)
        {
            this.points = r.points.ToList();
        }

        public Route(List<Point> list)
        {
            this.points = list;
            UpdateDistance();
        }

        public double GetLength()
        {
            UpdateDistance();
            return this.distance;
        }

        public void UpdateDistance()
        {
            double sum = 0;
            for (int i = 1; i < this.points.Count(); i++)
            {
                sum += this.points[i].GetDistanceToPoint(this.points[i - 1]);
            }
            sum += this.points[0].GetDistanceToPoint(this.points[this.points.Count() - 1]);
            this.distance = sum;
        }

        public Route Dup()
        {
            return new Route(this);
        }
    }
}
