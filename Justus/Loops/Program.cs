using System;
using System.Collections.Generic;

namespace Loops_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string decision = String.Empty;
              do
                {
                    Console.WriteLine("Please Enter a binary value");
                    string num = Console.ReadLine();
                    int length = num.Length;
                    double Answer = 0;
                    Console.WriteLine("This is " + num);

                    foreach (var number in num)
                    {
                        int power = length - 1;
                        if (number != '1' && number != '0')
                        {
                            Console.WriteLine("This number is not a binary");
                            break;
                        }
                        else
                        {
                            Answer += Math.Pow(2, power) * double.Parse(number.ToString());
                            length--;
                        }
                    }
                    Console.WriteLine("The equaivalent value of {0} is {1}", num, Answer);
                    Console.WriteLine("Do you want to continue conversion, write yes or no");
                    decision = Console.ReadLine();
                } while (decision.ToLower() == "yes");
        }
    }
}
