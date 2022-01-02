using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Reverse
    {
        static void Main() {
            int n;
            Console.WriteLine("Enter a number : ");
            n = int.Parse(Console.ReadLine());
            int reverse = ReverseOfNo(n);
            Console.WriteLine("The reverse of the number is : "+reverse);
        }
        static int ReverseOfNo(int n) {
            int sum = 0; int r = 0;
            while (n != 0) {
                 r = r % 10;
                sum = sum * 10 + r;
                n = n / 10;
            }
            return sum;
        }
    }
}
