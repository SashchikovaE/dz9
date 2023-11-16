using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov10
{
    internal class Rectangle : Point
    {
        public double length;
        public double width;
        public double ToCalculateArea(double x, double y, double x1, double y1, double x2, double y2)
        {
            length = Math.Sqrt(Math.Abs((x - x1) * (x - x1) + (y - y1) * (y - y1)));
            width = Math.Sqrt(Math.Abs((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)));
            Console.WriteLine($"длина - {length}, ширина - {width}");
            double s = length * width;
            Console.WriteLine($"площадь прямоугольника - {s}");
            return s;
        }
    }
}
