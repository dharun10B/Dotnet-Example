using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Example
{

    internal class calculate
    {
       
        public void Add(int a,int b) 
        {
            int result = a + b;
            Console.WriteLine($"Sum of {a} + {b} is :"+result);
        } 
        public void Subtract(int a,int b) 
        {
            int result = a - b;
            Console.WriteLine($"Subtract of {a} - {b} is :"+result);
        }
    }
}
