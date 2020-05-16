using System;
using System.IO;

namespace Exception_Handling
{
    class Program
    {

        static void Main(string[] args)
        {





            //**************************Solution to Assignment on Module 2*******************//


            //string decision = String.Empty;
            //do
            //{
            //    Console.WriteLine("Please Enter a binary value");
            //    string num = Console.ReadLine();
            //    int length = num.Length;
            //    double Answer = 0;

            //    foreach (var number in num)
            //    {
            //        int power = length - 1;
            //        if (number != '1' && number != '0')
            //        {
            //            Console.WriteLine("This number is not a binary");
            //            break;
            //        }
            //        else
            //        {

            //            Answer += Math.Pow(2, power) * double.Parse(number.ToString());
            //            length--;
            //        }
            //    }
            //    Console.WriteLine("The equaivalent value of {0} is {1}", num, Answer);
            //    Console.WriteLine("Do you want to continue with conversion, write yes or no");
            //    decision = Console.ReadLine();
            // } while (decision.ToLower() == "yes");
            //}


            //**************************End of Solution to Assignment on Module 2*******************//


            //*******************************Example 1*****************************//
            double val = 0;
            try
            {
                int age = int.Parse(Console.ReadLine());
                val = 12 / age;

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You entered zero");
            }
            catch (Exception e)
            {
                Console.WriteLine("There is a problem which am not sure of, contact admin \n " + e.Message);
            }
            finally
            {
                Console.WriteLine(val.ToString());
                Console.ReadKey();
            }

        }
        //******************************Example 2*******************************//
        //try
        //{
        //    Console.WriteLine("Enter your age");
        //    int val = int.Parse(Console.ReadLine());
        //    Console.WriteLine(val * 0.8);

        //}
        //catch (Exception)
        //{
        //    Console.WriteLine("You have a wrong value");
        //    throw;
        //}
        //Console.ReadKey();




        //******************************Example 3*******************************//

        //int a = int.Parse(Console.ReadLine());
        //if(a<5)
        //{
        //    throw new Exception("The value is less than 5");
        //}
        //Console.ReadKey();




        //******************************Example 4*******************************//
        //    StreamReader reader=null;
        //    try
        //    {
        //       reader = new StreamReader("MyFile.txt");
        //        Console.WriteLine(reader.ReadLine());
        //    }
        //    catch (FileNotFoundException)
        //    {
        //        Console.WriteLine("File Not Found");

        //    }
        //    catch(Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    finally{
        //        if(reader !=null)
        //        {
        //            reader.Close();
        //        }
        //        Console.ReadKey();
        //    }
        //}
    }
}
