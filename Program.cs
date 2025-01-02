using Dotnet_Example;
using static Dotnet_Example.calculate;

public delegate int mydelegate(int a, int b);
internal class Program
{
    //public delegate void calc(int a, int b);
    private static void Main(string[] args)
    {

        //ExceptionHandling Eh = new ExceptionHandling();
        //Eh.ExceptionHandlingFunction();

        //calc d;
        //calculate cl = new calculate();
        //d=cl.Add;
        //d(45, 24);
        //d = cl.Subtract;
        //d(33, 67);
        //Console.ReadKey();

        //Subscriber sb = new Subscriber();
        //sb.dowork();

        //Counter.Increment ci = new Counter.Increment();
        //ci.doIncrement();

        //FileInfoFunction fi = new FileInfoFunction();
        //fi.FileInfo();

        Console.Write("Enter the user name : ");
        string name = Console.ReadLine();
        Attendance o = new Attendance();
        Banned b = new Banned();

        o.BannedUser += b.UserBanned;

        o.ShowAttendance(name);

        Console.ReadKey();
    }
   
}