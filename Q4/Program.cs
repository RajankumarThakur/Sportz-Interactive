using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10; // Specify the value of N for which you want to find the Fibonacci number
            int fibonacci = CalculateFibonacci(n);

            Console.WriteLine($"The {n}th Fibonacci number is: {fibonacci}");
        }

        static int CalculateFibonacci(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("N must be a positive integer.");
            }

            if (n == 1 || n == 2)
            {
                return 1;
            }

            int prev = 1;
            int current = 1;

            for (int i = 3; i <= n; i++)
            {
                int temp = current;
                current = prev + current;
                prev = temp;
            }

            return current;
        }
    }

}
