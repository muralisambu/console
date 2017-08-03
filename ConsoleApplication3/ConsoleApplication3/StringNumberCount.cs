using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class StringNumberCount
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string ss = Console.ReadLine();
            StringCount(ss);
        }

        static int StringCount(string input)
        {
            Dictionary<int, int> store = new Dictionary<int, int>();
            store.Add(0, 6);
            store.Add(1, 2);
            store.Add(2, 5);
            store.Add(3, 5);
            store.Add(4, 4);
            store.Add(5, 5);
            store.Add(6, 6);
            store.Add(7, 3);
            store.Add(8, 7);
            store.Add(9, 5);
            char[] s = input.ToCharArray();
            int value = 0;
            foreach (char t in s)
            {
                if (store.ContainsKey(t - '0'))
                {
                    int ss = t - '0';
                    value = value + store[ss];
                }
            }
            Console.Write(value);
            Console.Read();
            return 0;
        }
    }
}
