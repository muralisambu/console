using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class staticexample
    {
        public static void Main()
        { //accessing static variables 
            Console.WriteLine(++Test.num);
            Console.ReadKey();
        }
        public static void TestMethod()
        {
            Console.WriteLine("This is from static method");
            Console.ReadKey();
        }
    }
    static class Test
    {
        public static int num = 5;
        static Test()
        {
            //accessing static methods
            staticexample.TestMethod();
        }
    }

}
