using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Example
{
public delegate void EventHandler(string name);

    internal class Attendance
    {
        public event EventHandler BannedUser;
        
        public void ShowAttendance(string name) 
        {
            
            if( name == "Jhon" || name=="Steven" || name == "Mathew")
            {
                BannedUser?.Invoke(name);
            }
            else
            {
                Console.WriteLine($"Welcome user :  {name}");
            }
        }
    }
    internal class Banned
    {
        public void UserBanned(string name)
        {
            Console.WriteLine($"{name}, you are banned from the organization.");
        }
    }
}
