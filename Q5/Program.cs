using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{

    public sealed class Circle
    {
        private double radius;

        public double Calculate(Func<double, double> op)
        {
            return op(radius);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.Calculate((r) => 2 * Math.PI * r);
            
        }
    }

}
