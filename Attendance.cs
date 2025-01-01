using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Example
{
    internal class Attendance
    {
        public void CaseInsensitiveFunction() 
        {

        }
        public void ShowAttendance() 
        {
            Console.WriteLine("Enter your Name :");
            String name=Console.ReadLine();
            Console.WriteLine($" \"Welcome\" {name}");
            if( name == "Jhon" || name=="Steven" || name == "Mathew")
            {

            }
        }
    }
}
