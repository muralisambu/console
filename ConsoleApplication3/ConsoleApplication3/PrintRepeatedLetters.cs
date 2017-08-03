using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class PrintRepeatedLetters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string inp = Console.ReadLine();
            RepeatedLetters(inp);
            Console.ReadLine();
        }

        public static string RepeatedLetters(string input)
        {
            char[] arr = input.ToCharArray();
            foreach(char i in arr)
            {
                Console.WriteLine(i);
            }
            var res = arr.GroupBy(x => x)
               .Select(x => new { Number = x.Key , Times = x.Count() });
            foreach(var s in res)
            {
                Console.WriteLine("{0} is {1} times", s.Number, s.Times);
            }
            return null;
        }
    }
}
