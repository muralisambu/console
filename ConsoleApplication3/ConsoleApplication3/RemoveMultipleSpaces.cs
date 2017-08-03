using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApplication3
{
    class RemoveMultipleSpaces
    {
        static Regex whitespace = new Regex(@"\s+", RegexOptions.Compiled);

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();

            Regex regex = new Regex("[ ]{2,}", RegexOptions.None);
           string tempo = regex.Replace(s, " ");
           Console.WriteLine(tempo);
            Console.Read();
        }
    }
}
