using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class AnagramPlaindrome
    {
        public static void fnAnagramPalindrome(string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            var oddCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                var temp = (char)str[i];
                if (!dict.ContainsKey(temp))
                {
                    dict.Add(temp, 1);
                }
                else
                {
                    dict[temp] += 1;
                }
            }

            foreach (var item in dict)
            {
                if (item.Value % 2 != 0)
                    oddCount++;

                if (oddCount > 1)
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            Console.WriteLine("Yes");
        }
    }
}
