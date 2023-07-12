using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 3;
            int power = 4;

            int result = CalculatePower(number, power);
            Console.WriteLine($"{number} raised to the power of {power} is: {result}");
        }

        static int CalculatePower(int number, int power, int partialResult = 1)
        {
            if (power == 0)
            {
                return partialResult;
            }

            return CalculatePower(number, power - 1, partialResult * number);
        }
    }

}
