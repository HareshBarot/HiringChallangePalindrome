using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString= Console.ReadLine();
            Console.WriteLine(longestPalindromesequrnce(inputString));
            Console.ReadKey();
        }

        private static int longestPalindromesequrnce(string inputString)
        {
            int maxLength = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                for (int j = inputString.Length - i; j >= i+1; j--)
                {
                    int len = longestPalindromeSubsequrnce(inputString.Substring(i, j));
                    maxLength = maxLength > len ? maxLength : len;
                }
            }
            return maxLength;
        }

        private static int longestPalindromeSubsequrnce(string v)
        {
            foreach (var item in v)
            {
                if (v.Where(x => x == item).Count() % 2 != 0) {
                    return 0;
                }
            }
            return v.Length;
        }
    }
}
