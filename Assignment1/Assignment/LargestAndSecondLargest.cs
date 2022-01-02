using System;


namespace Assignment
{
    
    class LargestAndSecondLargest
    {
        static void Main()
        {
            int num1, num2, num3;
            Console.WriteLine("Enter the First Number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Third Number");
            num3 = int.Parse(Console.ReadLine());
            int[] large = DetermineLargest(num1, num2, num3);
            Console.WriteLine("The Largest number is: " + large[0]);
            Console.WriteLine("The Second Largest number is: "+large[1]);
            Console.ReadLine();

        }
        static int[] DetermineLargest(int num1, int num2, int num3)
        {
            int[] large = new int[2];
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    large[0] = num1;
                    if (num2 > num3)
                    {
                        large[1] = num2;
                    }
                    else
                    {
                        large[1] = num3;
                    }
                }
                else
                {
                    large[0] = num3;
                    large[1] = num1;
                }
            }
            else
            {
                if (num2 > num3)
                {
                    large[0] = num2;
                    if (num1 > num3)
                    {
                        large[1] = num1;
                    }
                    else
                    {
                        large[1] = num3;
                    }

                }
                else {
                    large[0] = num3;
                    large[1] = num2;
                }
            }
            return large;
        }
    }
}
