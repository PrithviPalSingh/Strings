using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class GoobOrBadString
    {
        public static void fnGoodBadString(string str)
        {
            int vowelCount = 0;
            int consonantCount = 0;
            if (isVowel((char)str[0]))
            {
                vowelCount++;
            }
            else
            {
                consonantCount++;
            }

            for (int i = 1; i < str.Length; i++)
            {
                var temp = (char)str[i];

                if (temp == '?')
                {
                    vowelCount++;
                    consonantCount++;
                }
                else if (isVowel(temp))
                {
                    vowelCount++;
                    consonantCount = 0;
                }
                else
                {
                    consonantCount++;
                    vowelCount = 0;
                }

                if (vowelCount > 5 || consonantCount > 3)
                {
                    Console.WriteLine(0);
                    return;
                }
            }

            Console.WriteLine(1);
        }

        private static bool isVowel(char c)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                return true;
            }

            return false;
        }
    }
}
