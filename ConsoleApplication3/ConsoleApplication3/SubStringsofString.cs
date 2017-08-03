using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class SubStringsofString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            string s = Console.ReadLine();
            for (int i = 1; i <= s.Length; i++)
            {
                for (int j = 0; j <= s.Length-i; j++)
                {
                    string ss = s.Substring(j, i);
                    Console.WriteLine(ss);
                }
            }
            Console.ReadLine();
        }
    }
}
