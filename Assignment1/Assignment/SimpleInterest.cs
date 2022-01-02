using System;


namespace Assignment
{
    class SimpleInterest
    {
        static void Main(string[] args)
        {
            float principal;
            float rate;
            float time;
            Console.WriteLine("Enter the Principal: ");
            principal = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Rate of interest: ");
            rate = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Time period: ");
            time = float.Parse(Console.ReadLine());
            double SI = Simple_Interest(principal, rate, time);
            Console.WriteLine("Simple Interest is: "+SI);

        }
        private static double Simple_Interest(float Principal, float Rate, float Time) 
        {
            float interest = (Principal * Rate * Time) / 100;
            return interest;
        }
    }
}
