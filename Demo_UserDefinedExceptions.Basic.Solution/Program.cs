using System;

namespace Demo_UserDefinedExceptions.Basic.Solution
{
    /// <summary>
    /// Custom exception for division by zero
    /// Note: Constructor with message allows custom message to be displayed
    /// </summary>
    public class MyDivideByZeroException : Exception
    {
        public MyDivideByZeroException(string message) : base(message)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            double? quotient = null; // Note: double variable is now null-able

            Console.Write("Enter the first number: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            b = double.Parse(Console.ReadLine());

            try
            {
                quotient = Divide(a, b);
            }
            catch (MyDivideByZeroException ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }

            if (quotient != null)
            {
                Console.WriteLine();
                Console.WriteLine($"The quotient is: {quotient}"); // Note: New interpolation syntax
                Console.WriteLine();
            }


            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
        /// <summary>
        /// Method to manage double division, without infinity, that may divide by zero
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double? Divide(double a, double b) // Note: double function is now null-able
        {
            double? quotient = null;

            if (b != 0)
            {
                quotient = a / b;
            }
            else
            {
                throw new MyDivideByZeroException("I really hate it when you divide by zero!");
            }

            return quotient;
        }
    }
}

