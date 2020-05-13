using System;
using System.Collections.Generic;

namespace Decision_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            Console.WriteLine("Enter any number");
            int c =int.Parse(Console.ReadLine());
            if(c==a || c==b)
            {
                Console.WriteLine("You are on the track, nice guess");
            }
            else{
                Console.WriteLine("Guess again");
            }
            Console.ReadKey();
            //Console.WriteLine("Enter the number of students you are considering");
            //int StdNo = int.Parse(Console.ReadLine());
            //int StdCalc = 0;
            //do
            //{
            //    StdCalc++;
            //    Console.WriteLine("Enter the number of courses offered by this student");
            //    int courseNo = int.Parse(Console.ReadLine());
            //    List<double> scoreList = new List<double>();
            //    for (int i = 0; i < courseNo; i++)
            //    {
            //        Console.WriteLine("Enter the score for course {0}", i + 1);
            //        scoreList.Add(double.Parse(Console.ReadLine()));
            //    }

            //    foreach (var score in scoreList)
            //    {
            //        int point = 0;
            //        char grade = 'F';
            //        string status = "passed";
            //        if (score >= 70 && score <= 100)
            //        {
            //            grade = 'A'; point = 5;
            //        }
            //        else if (score >= 60 && score > 69)
            //        {
            //            grade = 'B'; point = 4;
            //        }
            //        else if (score >= 50 && score > 59)
            //        {
            //            grade = 'C'; point = 3;
            //        }
            //        else if (score >= 40 && score > 49)
            //        {
            //            grade = 'D'; point = 2;
            //        }
            //        else
            //        {
            //            grade = 'F'; point = 0;
            //            status = "failed";
            //        }

            //        Console.WriteLine("You have {0} point(s) and grade {1} having scored {2}- {3}", point, grade, score, status);
            //    }

            //} while (StdCalc < StdNo);
        }
    }
}
