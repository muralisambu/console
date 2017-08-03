using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            ChildClass cs = new ChildClass();
            cs.ClassA();
            cs.ClassB();
            cs.ClassC();
            cs.ClassD();
            BaseClass bs = new ChildClass();
            bs.ClassA();
            bs.ClassB();
            ChildClass csbs = (ChildClass)new BaseClass();
            Console.ReadKey();
        }
    }
}
