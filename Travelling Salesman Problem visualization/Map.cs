using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TravellingSalesmanProblemCpppp
{
    class Map
    {
        private static List<Point> points = new List<Point>();

        public static int delay = 0;

        public static Form1 form;

        public Map()
        {
            
        }

        public static void Start(Form1 form1)
        {
            Map.form = form1;
        }

        public static List<Point> GetPoints()
        {
            return Map.points;
        }

        public static void AddPoint(Point p)
        {
            Map.points.Add(p);
        }

        public static void DeleteAllPoints()
        {
            Map.points.Clear();
        }

        public static int GetCount()
        {
            return Map.points.Count();
        }

        #region Calculate Solution

        static Route s_bestRoute;
        static double s_bestLength;
        public static Route CalculateSolution()
        {
            s_bestLength = double.MaxValue;
            List<Point> list = Map.points.ToList();
            List<Point> route = new List<Point>();
            route.Add(list[0]);
            list.Remove(list[0]);
            F(list, route);
            form.GetGrid().Series[1].Points.Clear();
            return s_bestRoute;
        }

        static void F(List<Point> list, List<Point> route)
        {
            if (list.Count() == 1)
            {
                route.Add(list[0]);
                Route r = new Route(route);
                form.GetGrid().Series[1].Points.Clear();
                foreach (Point i in route)
                {
                    form.GetGrid().Series[1].Points.AddXY(i.GetX(), i.GetY());
                }
                if (r.GetLength() < s_bestLength)
                {
                    s_bestLength = r.GetLength();
                    s_bestRoute = r;
                    form.GetGrid().Series[2].Points.Clear();
                    foreach (Point i in s_bestRoute.points)
                    {
                        form.GetGrid().Series[2].Points.AddXY(i.GetX(), i.GetY());
                    }
                    form.GetGrid().Series[2].Points.AddXY(s_bestRoute.points[0].GetX(), s_bestRoute.points[0].GetY());
                }
                return;
            }
            foreach (Point item in list)
            {
                List<Point> list2 = list.ToList();
                List<Point> route2 = route.ToList();
                route2.Add(item);
                list2.Remove(item);
                F(list2, route2);
            }
        }
        //public static Route CalculateSolution(Form1 form)
        //{
        //    form.GetGrid().Series[1].Points.Clear();
        //    form.GetGrid().Series[2].Points.Clear();
        //    s_bestLength = double.MaxValue;
        //    foreach (Point item in Map.points)
        //    {
        //        List<Point> list = points.ToList();
        //        s_route = new Route(0);
        //        s_route.points.Add(item);
        //        list.Remove(item);
        //        Sfunc(form, list, item);
        //    }
        //}

        //private static void Sfunc(Form1 form, List<Point> list, Point fromPoint)
        //{
        //    if (list.Count() < 2)
        //    {
        //        s_route.points.Add(list[0]);
        //        foreach (Point i in s_route.points)
        //        {
        //            form.GetGrid().Series[1].Points.AddXY(i.GetX(), i.GetY());
        //        }
        //        if (s_route.GetLength() < s_bestLength)
        //    }
        //}
        #endregion

        #region Calculate Approximation

        static Route a_route;
        static Route a_bestRoute;
        static double a_bestLength;

        public static Route CalculateApproximation()
        {
            form.GetGrid().Series[1].Points.Clear();
            form.GetGrid().Series[2].Points.Clear();
            a_bestLength = double.MaxValue;
            foreach (Point item in Map.points)
            {
                List <Point> list = points.ToList();
                a_route = new Route(0);
                a_route.points.Add(item);
                list.Remove(item);
                fanc(list, item);
            }
            form.GetGrid().Series[1].Points.Clear();
            return a_bestRoute;
        }

        static void fanc(List<Point> list, Point fromPoint)
        {
            if (list.Count() < 2)
            {
                a_route.points.Add(list[0]);
                foreach (Point i in a_route.points)
                {
                    form.GetGrid().Series[1].Points.AddXY(i.GetX(), i.GetY());
                }
                Thread.Sleep(Map.delay);
                if (a_route.GetLength() < a_bestLength)
                {
                    a_bestLength = a_route.GetLength();
                    a_bestRoute = a_route.Dup();
                    form.GetGrid().Series[2].Points.Clear();
                    foreach (Point i in a_bestRoute.points)
                    {
                        form.GetGrid().Series[2].Points.AddXY(i.GetX(), i.GetY());
                    }
                    form.GetGrid().Series[2].Points.AddXY(a_bestRoute.points[0].GetX(), a_bestRoute.points[0].GetY());
                }
            }
            else
            {
                Point closestPoint = list[0];
                double closestDistance = double.MaxValue;
                foreach (Point p in list)
                {
                    if (p.GetDistanceToPoint(fromPoint) < closestDistance)
                    {
                        closestPoint = p;
                        closestDistance = p.GetDistanceToPoint(fromPoint);
                    }
                }
                
                a_route.points.Add(closestPoint);
                list.Remove(closestPoint);
                fanc(list, closestPoint);
            }
        }
        #endregion
    }
}
