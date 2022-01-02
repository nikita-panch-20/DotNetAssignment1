using System;


namespace Assignment
{
    class SwapTwoNumbers
    {
        static void Main()
        {
            int First, Second;
            Console.WriteLine("Enter the first number: ");
            First = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            Second = int.Parse(Console.ReadLine());
            int[] swap=Swapping(First, Second);
            Console.WriteLine("---After Swapping---");
            Console.WriteLine("First Number is: " + swap[0]);
            Console.WriteLine("Second Number is: " + swap[1]);
            Console.ReadLine();

        }
        static int[] Swapping(int First, int Second)
        {
            int[] swap = new int[2];
            First = First + Second;
            Second = First - Second;
            First = First - Second;

            swap[0] = First;
            swap[1] = Second;
            return swap;

            
        }
    }
}
