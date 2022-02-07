using System;

namespace _05._Multiplication_Sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            PositiveNegativeZero(num1, num2, num3);
        }
        static void PositiveNegativeZero(int num1, int num2, int num3)
        {
            if (num1==0 || num2==0 || num3==0)
            {
                Console.WriteLine("zero");
            }
            else
            {
                NegativePositive(num1, num2, num3);
            }
        }
        static void NegativePositive(int num1, int num2, int num3)
        {
            int[] nums = { num1, num2, num3 };
            int counter = 0;
            foreach (int num in nums)
            {
                if (num< 0)
                {
                    counter++;
                }
            }
            if (counter%2 == 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }
    }
}
