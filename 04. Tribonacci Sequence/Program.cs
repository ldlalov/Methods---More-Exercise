using System;

namespace _04._Tribonacci_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3 = 1, n4 = 0, i, number;
            number = int.Parse(Console.ReadLine());
            if (number>1)
            {
            Console.Write($"{n2} {n3}");
            for (i = 2; i < number; ++i)
            {
                n4 = n1 + n2 + n3;
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
