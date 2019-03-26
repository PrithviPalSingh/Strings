using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class FirstRepeatedCharacter
    {
        public static void fnFirstRepeatedCharacter(string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                var key = (char)str[i];
                if (!dict.ContainsKey(key))
                    dict.Add(key, 1);
                else
                {
                    Console.WriteLine(key);
                    return;
                }
            }

            Console.WriteLine(-1);
        }

        public static void FirstRepeated(string str)
        {
            // An integer to store presence/absence 
            // of 26 characters using its 32 bits. 
            int checker = 0;

            for (int i = 0; i < str.Length; ++i)
            {
                int val = (str[i] - 'a');

                // If bit corresponding to current 
                // character is already set 
                if ((checker & (1 << val)) > 0)
                {
                    Console.WriteLine(i);
                    return;
                }

                // set bit in checker 
                checker |= (1 << val);
            }

            Console.WriteLine(-1);
        }
    }
}
