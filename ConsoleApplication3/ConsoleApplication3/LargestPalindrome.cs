using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class LargestPalindrome
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the string");
            string name = Console.ReadLine();
           Console.WriteLine("The largest palindrome is {0}", length(name));
            Console.Read();
        }


        public static string length(string input)
        {
            //string output = "";
            //int minimum = 2;
            //for (int i = 0; i < input.Length - minimum; i++)
            //{
            //    for (int j = i + minimum; j < input.Length - minimum; j++)
            //    {
            //        string forstr = input.Substring(i, j - i);
            //        string revstr = new string(forstr.Reverse().ToArray());
            //        if (forstr == revstr && forstr.Length > minimum)
            //        {
            //            output = forstr;
            //            minimum = forstr.Length;
            //        }
            //    }
            //}
            //return output;


            int rightIndex = 0, leftIndex = 0;
            var x = "";
            string currentPalindrome = string.Empty;
            string longestPalindrome = string.Empty;
            for (int currentIndex = 1; currentIndex < input.Length - 1; currentIndex++)
            {
                leftIndex = currentIndex - 1;
                rightIndex = currentIndex + 1;
                while (leftIndex >= 0 && rightIndex < input.Length)
                {
                    if (input[leftIndex] != input[rightIndex])
                    {
                        break;
                    }
                    currentPalindrome = input.Substring(leftIndex, rightIndex - leftIndex + 1);
                    if (currentPalindrome.Length > x.Length)
                        x = currentPalindrome;
                    leftIndex--;
                    rightIndex++;
                }
            }
            return x;
        }
    }
}
