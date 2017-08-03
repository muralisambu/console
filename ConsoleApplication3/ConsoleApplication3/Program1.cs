using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program1
    {
        static void Main(string[] args)
        {
            sample1.bas();
        }
    }
    static class sample
    {
        public static void a()
        {
            Console.WriteLine("static class and method a");
        }
    }

    class sample1
    {
        public static void bas()
        {
            Console.WriteLine("Nornal clas with static method");
        }
    }
    
}
