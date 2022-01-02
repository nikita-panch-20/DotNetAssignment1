using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class BinaryToDecimal
    {
        static void Main()
        {
            Console.Write("Enter the Binary Number : ");
            int binaryNumber = int.Parse(Console.ReadLine());
            int decimalValue=ToDecimal(binaryNumber);
            Console.Write("Decimal Value : {0} ", decimalValue);
            Console.ReadLine();
        }
        static int ToDecimal(int binaryNumber) {
            int decimalValue = 0;
            int base1 = 1;
            while (binaryNumber > 0)
            {
                int reminder = binaryNumber % 10;
                binaryNumber = binaryNumber / 10;
                decimalValue += reminder * base1;
                base1 = base1 * 2;
            }
            return decimalValue;
        }
    }
}
