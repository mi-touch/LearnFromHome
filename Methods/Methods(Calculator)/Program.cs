using System;

namespace Methods_Calculator_
{
    class Program
    {

        //**************************************Content**************************//
        //Why do we use methods?
        //Where can I declare my method?
        //How to declare method
        //Local Variables
        //Arguments/Parameters
        //Invoking a method
        //Access Modifiers
        //Variable no of args
        //Optional and Named Parameters
        //Methods Overloading
        //Returning a value from a method

        static void Main(string[] args)
        {

            Assignment2 assignment2 = new Assignment2();
          
            
            double a = 7;
            double b = 10;

            double result = AdditionOfTwoValues(7, 10);
            Printer(result.ToString());

            double result2 = AdditionOfTwoValues(17, 23);
            Printer(result2.ToString());

            double[] vals = new double[] { 2, 3, 4, 5, 6, 7, 87, 8, 98, 9, 9, 5 };
            double Answer = AdditionOfManyValues(vals);

            double result3 = AdditionOfTwoValues(3, y: 7);

            Printer(Answer.ToString());

            Console.WriteLine(AdditionOfTwoValues(3, 4));
        }

        static double AdditionOfTwoValues(double x=9, double y=6)
        {
            double z = x + y;
            return z;
        }
       // <return type> <methodname> <para

      
       //Methods Overloading
        static int AdditionOfTwoValues(int x = 9, double y = 6)
        {
            int z = x + Convert.ToInt32(y);
            return z;
        }

        static double AdditionOfManyValues(double[] vals)
        {
            double sum = 0;
            foreach (var item in vals)
            {
                sum = sum + item;
            }
            return sum;
        }
        static void Printer(string val)
        {
            Console.WriteLine(val);
        }
        static void Checker()
        {
            Console.WriteLine("jhsdfhsbf");
        }
    }
}

