using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class RevOfString
    {
        static void Main()
        {
            string str = "", rev = "";
            int Length = 0;
            Console.WriteLine("Enter the String");
            str = Console.ReadLine();
            Length = str.Length - 1;
            while (Length >= 0)
            {
                rev = rev + str[Length];
                Length--;
            }
            Console.WriteLine("Reverse os String is {0}", rev);
            Console.ReadLine();
        }
    }
}
