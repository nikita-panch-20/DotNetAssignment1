using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Client
    {
        public static void Main()
        {
            int resource = 0;
            double totalres = 0;
            double rate = 0;
            double totalHours = 0;
            double hardware = 0;
            double software = 0;
            double extrcons = 0;
            double charges = 0;
            Console.WriteLine("Enter the dollar rate per hour");
            rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Number of Resources Used");
            resource = Convert.ToInt32(Console.ReadLine());

            int[] res = new int[resource];

            Console.WriteLine("Enter the number of hours each resource was used");
            for (int i = 0; i < resource; i++)
            {
                Console.WriteLine("Resource" + i + "is used for:");
                res[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Console.WriteLine("Enter the total no. of hours each resource was used");
            //totalHours = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Cost of Hardware Purchased");
            hardware = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Cost of Software Purchased");
            software = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("External Consultants used for how many hours");
            extrcons = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < resource; i++)
            {
                totalres += res[i];
            }
            charges = totalres * rate + 0.3 * hardware + 0.5 * software - extrcons * 10 - 0.7 * hardware - 0.5 * software;
            Console.WriteLine("Profit is: " + charges);
            Console.ReadLine();
        }

    }
}
