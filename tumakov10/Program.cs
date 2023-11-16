using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("упражнение 10.1");
            Console.WriteLine("введите слово, которое вы хотите зашифровать");
            string word = Console.ReadLine();
            word.ToLower();
            ACipher aCipher = new ACipher();
            aCipher.encode(word);

            Console.WriteLine("   введите слово, которое вы хотите расшифровать");
            string word2 = Console.ReadLine();
            word2.ToLower();
            aCipher.decode(word2);

            BCipher bCipher = new BCipher();
            bCipher.encode(word);
             
            Console.WriteLine("введите слово, которое хотите расшифровать");
            string word3 = Console.ReadLine();
            bCipher.decode(word3);

            Console.WriteLine("   дз 10.1");
            Point point = new Point();
            Rectangle rectangle = new Rectangle();
            Circle circle = new Circle();
            Figure figure = new Figure();
            rectangle.ToCalculateArea(0, 4, 1, 6, 9, 2);
            point.RemoveHorizontallyLeft(0, 1, 9, 8);
            circle.ToCalculateArea(0, 0, 0, 7);
            rectangle.ChangeColor();
            circle.ChangeColor();
            Console.ReadKey();
        }
    }
}
