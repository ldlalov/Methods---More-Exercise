using System;

namespace _02._Center_Point
{
    internal class Program
    {

        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            if (FirstPoint(x1,y1)>SecondPoint(x2,y2))
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }
        static double FirstPoint(double x1, double y1)
        {
            double firstDistance = x1 * x1 + y1 * y1;
            return firstDistance;
        }
        static double SecondPoint(double x2, double y2)
        {
            double[] secondPoint = {x2, y2};
            double secondDistance = x2*x2 + y2*y2;
            return secondDistance;
        }
    }
}
