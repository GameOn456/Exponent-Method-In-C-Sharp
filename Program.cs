using System;

namespace ExponentMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Exponent(4, 2));
        }

        static double Exponent(double numBase, double power)
        {
            double result = 1;

            for (int i = 0; i < numBase; i++)
            {
                result *= power;
            }

            return result;
        }
    }
}
