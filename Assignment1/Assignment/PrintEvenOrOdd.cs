using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class PrintEvenOrOdd
    {
        static void Main()
        {
            int num;
            Console.WriteLine("Enter a Number: ");
            num = int.Parse(Console.ReadLine());
            string result = EvenOrOdd(num);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static string EvenOrOdd(int num)
        {
            if (num % 2 == 0)
            {
                return "The Number is Even";
            }
            else 
            {
                return "The Number is Odd";
            }
        }
    }
}
