using System;


namespace Assignment
{
    class Ranking
    {
        static void Main()
        {
            String name;
            int score1, score2, score3;
            Console.WriteLine("Enter the Student's Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the score 1: ");
            score1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the score 2: ");
            score2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the score 3: ");
            score3 = int.Parse(Console.ReadLine());
            float avg = FindAverage(score1, score2, score3);
            if (avg >= 60)
            {
                Console.WriteLine("The student has secured 1st class");
            }
            else if (avg >= 50 && avg < 60)
            {
                Console.WriteLine("The student has secured 2nd class");
            }
            else if (avg >= 35 && avg < 50)
            {

                Console.WriteLine("The student secured pass class");
            }
            else {
                Console.WriteLine("The student failed");
            }

        }
        static float FindAverage(int score1, int score2, int score3) {
            int total=score1+score2+score3;
            float avg=total/3;
            return avg;
        }
    }
}
