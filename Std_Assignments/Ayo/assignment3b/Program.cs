using System;

namespace Assignment3b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter binary number: ");
            int n = Int32.Parse(Console.ReadLine());
            string toDecimal = Convert.ToString(Convert.ToInt32(n, 2), 10);
            Console.WriteLine("Result is {0}", toDecimal);
            
            Console.ReadKey();
        }
    }
}
