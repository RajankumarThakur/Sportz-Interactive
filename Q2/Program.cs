using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("valar morghulis");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("valar");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("morghulis");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

}
