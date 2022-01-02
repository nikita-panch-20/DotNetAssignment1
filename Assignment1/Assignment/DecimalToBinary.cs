using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class DecimalToBinary
    {
        static void Main()
        {
            string dec;
            string bin = "";

            Console.Write("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num > 1)
            {
                int remainder = num % 2;
                bin = Convert.ToString(remainder) + bin;
                num /= 2;
            }
            bin = Convert.ToString(num) + bin;
            Console.WriteLine("Binary: {0}", bin);
            Console.ReadLine();
        }
    }
}
