using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class UncommonCharacters
    {
        public static void fnPrintUnCommonCharacters(string a, string b)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < 26; i++)
            {
                dict.Add((char)(i + 97), 0);
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (dict[(char)a[i]] == 0)
                    dict[(char)a[i]] = 1;
            }

            for (int i = 0; i < b.Length; i++)
            {
                if (dict[(char)b[i]] == 0)
                {
                    dict[(char)b[i]] = 2;
                }
                else if (dict[(char)b[i]] == 1)
                {
                    dict[(char)b[i]] = -1;
                }
            }

            foreach (var item in dict)
            {
                if (item.Value == 1 || item.Value == 2)
                    Console.Write(item.Key);
            }

            Console.WriteLine();
        }
    }
}
