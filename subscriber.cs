using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Example
{
    class Subscriber
    {
        public void dowork()
        {
            Publisher p = new Publisher();
            //p.Myevent += delegate (int a, int b)
            //{
            //    int result = a + b;
            //    Console.WriteLine($"Sum of {a} + {b} is :" + result);
            //};
            p.Myevent += (a, b) => (a + b); //Lambda Expression
            p.increment();
        }
    }
}
