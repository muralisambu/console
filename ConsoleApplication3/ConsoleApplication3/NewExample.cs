using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class NewExample
    {
        public static void Main()
        {
            ChildsClass c = new ChildsClass();
            ((ParentClass)c).print();
            Console.ReadKey();
        }
    }
    public class ParentClass
    {
        public void print()
        {
            Console.WriteLine("this is from print");
            Console.ReadKey();
        }
    }
    public class ChildsClass : ParentClass
    {
        public new void print()
        {
            base.print();
            Console.WriteLine("this is from printed ");
            Console.ReadKey();
        }
    }
}
