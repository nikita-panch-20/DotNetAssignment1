using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class SumOfOddNos
    {
        static void Main() {
            int N;
            Console.WriteLine("Enter the range: ");
            N = int.Parse(Console.ReadLine());
            int sum = SumOddNos(N);
            Console.WriteLine("The Sum of odd numbers is : "+sum);
        }
        static int SumOddNos(int N) {
            int sum = 0;
            for (int i = 1; i <= N; i++) {
                if (N % 2 != 0) {
                    sum = sum + i;
                }
            }
            return sum;
        }
    }
}
