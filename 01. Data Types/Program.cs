using System;

namespace _01._Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            switch (input)
            {
                case "int":
                    Console.WriteLine(Int());
                        break;
                case "real":
                    Console.WriteLine(Real());
                        break;
                case "string":
                    Console.WriteLine(String());
                        break;
            }
        }
      static int Int()
    {
            int num = int.Parse(Console.ReadLine());
            num *= 2;
            return num;
    }
      static string Real()
    {
            double num = double.Parse(Console.ReadLine());
            num *= 1.50;
            return $"{num:f2}";

        }
        static string String()
    {
            string str = Console.ReadLine();
            return $"${str}$";
    }

    }
}
