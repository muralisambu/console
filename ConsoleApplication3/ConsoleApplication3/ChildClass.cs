using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class ChildClass : BaseClass
    {
        public ChildClass()
        {
            Console.WriteLine("From child Class Constructor");
        }

        public void ClassC()
        {
            Console.WriteLine("from derived class Method C");
            
        }

        public void ClassD()
        {
            Console.WriteLine("from derived clas Method D");
        }
    }
}
