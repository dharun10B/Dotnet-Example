using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dotnet_Example
{
    internal class FileInfoFunction
    {
        public void FileInfo() 
        {
            FileInfo f;
            f = new FileInfo(@"C:\4561\backend\C#\.net-notes.txt");
            Console.WriteLine("Exists :"+f.Exists);
            if (f.Exists)
            {
                Console.WriteLine("Name :"+f.Name);
                Console.WriteLine("Full_Name :"+f.FullName);
                Console.WriteLine("Extension: " + f.Extension);
                Console.WriteLine("Creation date and time: " + f.CreationTime);
                Console.WriteLine("Modification date and time: " +
               f.LastWriteTime);
                Console.WriteLine("Access date and time: " + f.LastAccessTime);
                Console.WriteLine("Length: " + f.Length + " bytes");
            }
        }
    }
}
