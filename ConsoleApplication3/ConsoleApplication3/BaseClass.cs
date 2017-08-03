using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("From base class Constructor");
        }

        public BaseClass(string input)
        {
            Console.WriteLine(input);
        }

        public virtual void ClassA()
        {
            Console.WriteLine("from base class method ClassA");
        }

        public virtual void ClassB()
        {
            Console.WriteLine("from base class method ClassB");
        }
    }
}
