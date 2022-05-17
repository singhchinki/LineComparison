using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    internal class Line
    {
        public double getLength(double x1, double y1, double x2, double y2)
        {
            double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return result;
        }
        public void compare(double length1, double length2)
        {
            if (length1.Equals(length2))
                Console.WriteLine("Length of line" + length1+ "is equal" + length2);
            else if (length1 > length2)
                Console.WriteLine("Length of line" + length1+ "is greater to" + length2);
            else
                Console.WriteLine("Length of line" + length1+ "is less than to" + length2);


        }
    }
}
