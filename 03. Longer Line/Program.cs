using System;
using System.Linq;

namespace _03._Longer_Line
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] firstLine = Line();
            double[] secondLine = Line();
            double[] longerLine = new double[4];
            double firstLineLength = Math.Abs(Length(firstLine));
            double secondLineLength = Math.Abs(Length(secondLine));
            if (firstLineLength >= secondLineLength)
            {
                longerLine = firstLine;
            }
            else
            {
                longerLine = secondLine;
            }
            if (FirstPoint(longerLine[0], longerLine[1]) <= SecondPoint(longerLine[2], longerLine[3]))
            {
                Console.WriteLine($"({String.Join(", ", longerLine[0], longerLine[1])})({String.Join(", ", longerLine[2], longerLine[3])})");
            }
            else
            {
                Console.WriteLine($"({String.Join(", ", longerLine[2], longerLine[3])})({String.Join(", ", longerLine[0], longerLine[1])})");
            }


        }
        static double[] Line()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double[] line = { x1, y1, x2, y2 };
            return line;
        }
        static double FirstPoint(double x1, double y1)
        {
            double firstDistance = x1 * x1 + y1 * y1;
            return firstDistance;
        }
        static double SecondPoint(double x2, double y2)
        {
            double secondDistance = x2 * x2 + y2 * y2;
            return secondDistance;
        }

        static double Length(double[] line)
        {

            double x1 = line[0];
            double y1 = line[1];
            double x2 = line[2];
            double y2 = line[3];
            double length = Math.Sqrt((x2-x1)+(y2-y1));

            return length;
        }
    }
}

