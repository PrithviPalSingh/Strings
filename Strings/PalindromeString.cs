using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class PalindromeString
    {
        public static void fnPalindrome(string str, int n)
        {
            bool isPalindrome = true;
            for (int i = 0; i < n / 2; i++)
            {
                if (str[i] != str[n - 1 - i]) {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
