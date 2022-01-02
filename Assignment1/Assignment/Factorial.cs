using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Factorial
    {
        static void Main() {
            int n;
            Console.WriteLine("enter a number");
            n = int.Parse(Console.ReadLine());
            int fact = Fact(n);
            Console.WriteLine("Factorial of given number: "+fact);
            Console.ReadLine();
        }
        static int Fact(int n) {
            int fact=0;
            if (n < 0)
            {
                Console.WriteLine("Not possible");
            }
            else if (n == 0)
            {
                fact = 1;
            }
            else {
                fact = n * Fact(n - 1);
            }
            return fact;
        }
    }
}
