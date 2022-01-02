using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Power
    {
        static void Main()
        {
            int x, n, temp;
            Console.WriteLine("Enter x");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter n");
            n = Convert.ToInt32(Console.ReadLine());
            int res = XpowerN(n, x);
            Console.WriteLine($"X power N is {0}", res);
            Console.ReadLine();
        }
        static int XpowerN(int n, int x) {
            int temp = x;
            for (int i = 1; i < n; i++)
            {
                x = x * temp;
            }
            return x;
        }
    }
}
