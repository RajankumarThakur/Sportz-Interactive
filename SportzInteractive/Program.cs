using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportzInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sumOfEvens = SumEvenNumbers(numbers);
            Console.WriteLine("Sum of even numbers: " + sumOfEvens);
        }


        public static int SumEvenNumbers(int[] numbers)
        {
            int sum = 0;

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }

            return sum;
        }

    }
}
