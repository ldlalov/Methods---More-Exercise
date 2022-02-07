using System;

namespace _04._Tribonacci_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Tribonacci(number);

        }
        static void Tribonacci(int number)
        {
            int n1 = 0, n2 = 1, n3 = 1, i;
            if (number > 1)
            {
                Console.Write($"{n2} {n3}");
                for (i = 2; i < number; ++i)
                {
                    int n4 = n1 + n2 + n3;
                    n1 = n2;
                    n2 = n3;
                    n3 = n4;
                    Console.Write($" {n4}");
                }
            }
            else
            {
                Console.WriteLine(number);
            }

        }
    }
}
