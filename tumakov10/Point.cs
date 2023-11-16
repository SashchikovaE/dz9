using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace tumakov10
{
    internal class Point : Figure
    {
        public double x;
        public double y;
        public void RemoveVerticallyDown(double y1, double y2, double y3, double y4)
        {   
            y1--;
            y2--;
            y3--;
            y4--;
            Console.WriteLine($"отныне координаты вершины по оу - {y1}, {y2}, {y3}, {y4}");
        }
        public void RemoveVerticallyUp(double y1, double y2, double y3, double y4)
        {
            y1++;
            y2++;
            y3++;
            y4++;
            Console.WriteLine($"отныне координаты вершины по оу - {y1}, {y2}, {y3}, {y4}");
        }
        public void RemoveHorizontallyRight(double x1, double x2, double x3, double x4)
        {
            x1++;
            x2++;
            x3++;
            x4++;
            Console.WriteLine($"отныне координаты вершины по ох - {x1}, {x2}, {x3}, {x4}");
        }
        public void RemoveHorizontallyLeft(double x1, double x2, double x3, double x4)
        {
            x1--;
            x2--;
            x3--;
            x4--;
            Console.WriteLine($"отныне координаты вершины по ох - {x1}, {x2}, {x3}, {x4}");
    }
    }
}