using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace tumakov10
{
    enum Status
    {
        visible,
        invisible
    }
    internal class Figure : IFigure
    {
        public string color;
        public Status status;
        public bool StatusSurvey()
        {
            if (status == Status.visible)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ChangeColor()
        {
            string[] colors = new string[5] { "red", "green", "blue", "yellow", "purple" };
            Random random = new Random();
            int index = random.Next(colors.Length);
            string color = colors[index];
            Console.WriteLine($"цвет фигуры - {color}");
        }
    }
}

// ты все сможешь ты лохушка немного но ты все сможешь)


