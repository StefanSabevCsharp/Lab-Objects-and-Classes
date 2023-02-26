using System;
using System.Numerics;
namespace _2._Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = new BigInteger();
            number = 1;
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                number *= i;
            }
            Console.WriteLine(number);
        }
    }
}
