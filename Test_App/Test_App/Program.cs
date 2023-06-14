using System;

namespace Test_App
{
    internal class Program
    {
        public static double Rect_Area(double width, double height)
        {
            return width * height;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine(Rect_Area(rnd.Next(1,10), rnd.Next(1,10)));
        }
    }
}


