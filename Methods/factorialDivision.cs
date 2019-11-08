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
            long firstFactorialBase = long.Parse(Console.ReadLine());
            long secondFactorialBase = long.Parse(Console.ReadLine());
            long firstFactorial = FactorialReturn(firstFactorialBase);
            long secondFactorial = FactorialReturn(secondFactorialBase);
            double result = 1.0 * firstFactorial / secondFactorial;
            Console.WriteLine($"{result:f2}");
        }

        static long FactorialReturn(long factorialBase)
        {
            long factorial = 1;
            for (long i = 1; i <= factorialBase; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
