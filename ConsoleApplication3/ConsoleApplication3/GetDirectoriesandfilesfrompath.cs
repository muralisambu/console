using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class GetDirectoriesandfilesfrompath
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the path");
            string path = Console.ReadLine();
            string[] arr = Directory.GetFiles(path,"*.jpg");
            DateTime time = Directory.GetCreationTime(path);
            Console.WriteLine(time);
            foreach(string s in arr)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
