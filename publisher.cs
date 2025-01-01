using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Example
{
    internal class Publisher
    {
        public event mydelegate Myevent;

        public int x=0, y=0;

        public void increment()
        {
            Console.WriteLine("Enter first number :");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number :");
            y = Convert.ToInt32(Console.ReadLine());
            x +=5;
            y +=5;
            int result=Myevent(x,y);
            Console.WriteLine(result);
            Myevent(x,y);
        }
    }
}
