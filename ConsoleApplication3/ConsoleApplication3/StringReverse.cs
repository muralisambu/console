using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class StringReverse
    {
        public static void Main(string[] args)
        {
             string name="This is new world";
             string[] arrrr = name.Split(' ');
             
            for(int i=0; i<arrrr.Length; i++)
            {
                String s = arrrr[i];
                char[] ss = s.ToCharArray();
                Array.Reverse(ss);
                Console.Write("{0} ", new string(ss));
            }
            Console.ReadKey();
        }
    }
}
