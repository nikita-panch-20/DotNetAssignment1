using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class PrimeNumbers
    {
        static void Main() {
            int n, m;
            Console.WriteLine("Enter the range: ");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            int sum = SumPrime(n, m);
            Console.WriteLine("The final sum is : "+sum);
            Console.ReadLine();
            
        }
        static int SumPrime(int n, int m) {
            int sum = 0;
            for (int i = n; i <= m; i++)
            {
                for (int j = 2; j < n; j++)
                {
                    if (i % j != 0)
                    {
                        Console.WriteLine(i + " ");
                        sum = sum + i;

                    }

                }
            }
            return sum;
        }
    }
}
