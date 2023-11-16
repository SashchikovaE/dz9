using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov10
{
    internal class Circle : Point
    {
        public double R;
        public double ToCalculateArea(double x1, double y1, double x2, double y2)
        {
            double R = Math.Sqrt(Math.Abs((x1 - x2) * (x1-x2) + (y1 - y2) * (y1 - y2)));
            double S = Math.PI * R * R;
            return S;
        }
    }
}
