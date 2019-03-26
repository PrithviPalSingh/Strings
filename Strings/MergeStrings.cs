using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class MergeStrings
    {
        public static void fnMergeStrings(string s1, string s2)
        {
            int i = 0;
            string newStr = string.Empty;

            while (i != s1.Length && i != s2.Length)
            {
                newStr += (char)s1[i];
                newStr += (char)s2[i];
                i++;
            }

            if (i < s1.Length)
            {
                while (i != s1.Length)
                {
                    newStr += (char)s1[i];
                    i++;
                }
            }

            if (i < s2.Length)
            {
                while (i != s2.Length)
                {
                    newStr += (char)s2[i];
                    i++;
                }
            }

            Console.WriteLine(newStr);
        }
    }
}
