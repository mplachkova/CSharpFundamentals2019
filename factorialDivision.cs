using System;
using System.Numerics;

namespace factorialDivision
{
    class factorialDivision
    {
        static void Main(string[] args)
        {
            //Read two integer numbers.
            //Calculate factorial of each number.
            //Divide the first result by the second and print the division formatted to the second decimal point.
            ulong firstFactorialBase = ulong.Parse(Console.ReadLine());
            ulong secondFactorialBase = ulong.Parse(Console.ReadLine());
            ulong firstFactorial = FactorialReturn(firstFactorialBase);
            ulong secondFactorial = FactorialReturn(secondFactorialBase);
            double result = 1.0 * firstFactorial / secondFactorial;
            Console.WriteLine($"{result:f2}");
        }

        static ulong FactorialReturn(ulong factorialBase)
        {
            ulong factorial = 1;
            for (ulong i = 1; i <= factorialBase; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}