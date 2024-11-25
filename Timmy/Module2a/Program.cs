using System;

namespace LearnFromHome
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment 1: Quadratic Equation Solver
            Console.WriteLine("Assignment 1: Solve the Quadratic Equation");
            Console.Write("Enter value for a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter value for b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter value for c: ");
            int c = int.Parse(Console.ReadLine());

            double discriminant = Math.Pow(b, 2) - 4 * a * c;

            if (discriminant == 0)
            {
                double root = -b / (2.0 * a);
                Console.WriteLine($"Both roots are equal: x1 = x2 = {root}");
            }
            else if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"The roots are real and distinct: x1 = {root1}, x2 = {root2}");
            }
            else
            {
                Console.WriteLine("The roots are imaginary (no real solutions).");
            }
            Console.WriteLine();

            // Assignment 2: Fahrenheit to Celsius Converter
            Console.WriteLine("Assignment 2: Convert Fahrenheit to Celsius");
            double fahrenheit = 79.0;
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"Fahrenheit: {fahrenheit}°F is equivalent to Celsius: {celsius}°C");
            Console.WriteLine();

            // Assignment 3: Palindrome Checker
            Console.WriteLine("Assignment 3: Palindrome Checker");
            Console.Write("Enter an integer: ");
            int userInput = int.Parse(Console.ReadLine());
            int reversed = 0, temp = userInput;

            while (temp != 0)
            {
                int remainder = temp % 10;
                reversed = reversed * 10 + remainder;
                temp /= 10;
            }

            if (userInput == reversed)
            {
                Console.WriteLine($"The number {userInput} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"The number {userInput} is not a palindrome.");
            }
        }
    }
}
