using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Example
{
    internal class ExceptionHandling
    {
        public void ExceptionHandlingFunction() 
        {
            try
            {
                Console.WriteLine("Enter first number :");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second Number :");
                int b = Convert.ToInt32(Console.ReadLine());
                int c = a / b;
                Console.WriteLine("Quotient is " + c);
            }
            catch(Exception ex) 
            {
                    Console.WriteLine(ex.Message);
            }
                finally 
            {
                Console.WriteLine(" finished");
            }
            Console.ReadKey();
        }
    }
}
