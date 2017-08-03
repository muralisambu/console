using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class CountOfWords
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] arg = s.Split(' ');
            var res = arg.GroupBy(x => x)
                .Select(x => new { Number = x.Key, Times = x.Count() }).ToList();
            foreach(var ss in res)
            {
                Console.WriteLine("{0} is {1} times", ss.Number, ss.Times);
            }
            Console.Read();
        }
    }
}
