using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class CheckSubsequence
    {
        public static void fnIsSubsequence(string a, string b)
        {
            int i = 0;
            int j = 0;

            while (j < b.Length)
            {
                if (a[i] == b[j])
                {
                    i++;
                    j++;
                }
                else {
                    j++;
                }

                if (i == a.Length) {
                    Console.WriteLine(1);
                    return;
                }
            }

            Console.WriteLine(0);
        }
    }
}
