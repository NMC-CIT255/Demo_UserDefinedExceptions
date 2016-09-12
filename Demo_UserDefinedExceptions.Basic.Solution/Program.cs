using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_UserDefinedExceptions.Basic.Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            double? quotient = null;

            Console.Write("Enter the first number: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            b = double.Parse(Console.ReadLine());

            try
            {
                quotient = Divide(a, b);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }

            if (quotient == null)
            {
                Console.WriteLine();
                Console.WriteLine($"The quotient is: {quotient}");
                Console.WriteLine();
            }


            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        static double? Divide(double a, double b)
        {
            double? quotient = null;

            if (b != 0)
            {
                quotient = a / b;
            }
            else
            {
                throw new DivideByZeroException();
            }

            return quotient;
        }
    }
}
