using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class FirstNonRepeatingCharacter
    {
        public static void fnFirstNonRepeatingCharater(string str)
        {
            int[] countArr = new int[26];

            for (int i = 0; i < str.Length; i++)
            {
                countArr[str[i] - 'a']++;
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (countArr[str[i] - 'a'] == 1)
                {
                    Console.WriteLine(str[i]);
                    return;
                }
            }

            Console.WriteLine(-1);
        }
    }
}
