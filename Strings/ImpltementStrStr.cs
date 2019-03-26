using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class ImpltementStrStr
    {
        public static void fnStrStr(string a, string b)
        {
            int n = a.Length;
            int m = b.Length;
            if (m > n)
            {
                Console.WriteLine(-1);
                return;
            }

            if (a == b)
            {
                Console.WriteLine(0);
                return;
            }

            // create lps[] that will hold the longest prefix suffix values for pattern 
            int[] lps = new int[n];

            // length of the previous longest prefix suffix 
            int len = 0;
            int i = 1;

            // lps[0] is always 0 
            lps[0] = 0;

            // the loop calculates lps[i] for i = 1 to n-1 
            while (i < n)
            {
                if (a[i] == b[len])
                {
                    lps[i] = ++len;

                    if (lps[i] == b.Length)
                    {
                        Console.WriteLine(i - lps[i] + 1);
                        return;
                    }

                    ++i;
                }
                else
                {
                    if (len == 0)
                    {
                        lps[i] = 0;
                        ++i;
                    }
                    else
                    {
                        len = lps[len - 1];
                    }
                }
            }

            Console.WriteLine(-1);
        }
    }
}
