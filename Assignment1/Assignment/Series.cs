using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Series
    {
        static void Main() {
            int n;
            Console.WriteLine("Enter the range: ");
            n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++) {

                for (int j = 1; j <= i; j++) {
                    int res = i * j;
                    Console.WriteLine(res+", ");
                }
            }
            Console.ReadLine();
        }
    }
}
