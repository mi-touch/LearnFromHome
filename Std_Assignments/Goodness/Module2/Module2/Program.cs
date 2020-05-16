using System;

namespace Module2
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;

namespace LearnFromHome3
    {
        class Program
        {
            static void Main(string[] args)
            {
                //Assignment 1
                Console.WriteLine("Enter number");
                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    if (i % 3 != 0 && i % 7 != 0)
                    {
                        Console.WriteLine("{0}", i);
                    }
                }

                //Assignment 2
                int BinaryNum;
                int DecimalNum = 0;
                int BaseValue = 1;
                int R; // R is for remainder
                Console.WriteLine("Input the binary number you want to convert");

                int m = int.Parse(Console.ReadLine());

                BinaryNum = m;
                if (m % 10 > 1)
                {
                    Console.WriteLine("Please enter a Binary number");
                }
                while (m > 0)
                {
                    R = m % 10;
                    DecimalNum = DecimalNum + R + BaseValue;
                    m = m / 10;
                    BaseValue = BaseValue * 2;

                }
            }
        }
    }
}
    }
}
