using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class FractionalAndIntegralParts
    {
        static void Main() {
            double num;
            Console.WriteLine("Enter the Decimal number: ");
            num = double.Parse(Console.ReadLine());
            int whole = IntegralAndFractional(num);
            Console.WriteLine("The Whole part is: " + whole);
            Console.WriteLine("The Fractional part is: " + (num - whole));
            Console.ReadLine();

        }
       static int IntegralAndFractional(double num)
        {
            int integral = (int)num;
            return integral;
        }
    }
}
