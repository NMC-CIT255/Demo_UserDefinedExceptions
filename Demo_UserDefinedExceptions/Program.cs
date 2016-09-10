using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_UserDefinedExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Divide(5, 0);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("I think you tried to divide by zero!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("I will be sure to write this no matter what.");
            }


            Console.ReadKey();
        }

        static void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
}
