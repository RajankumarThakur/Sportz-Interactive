using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    public enum Colors
    {
        Red,
        Blue,
        Green,
        Yellow
    }

    class Program
    {
        static void Main(string[] args)
        {
            foreach (Colors color in Enum.GetValues(typeof(Colors)))
            {
                Console.WriteLine(color);
            }
        }
    }

}
