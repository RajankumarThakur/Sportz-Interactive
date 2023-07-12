using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{  

    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("Before swapping:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            // Swap the numbers without a temporary variable
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;

            Console.WriteLine("After swapping:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }

}
