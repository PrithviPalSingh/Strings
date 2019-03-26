using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class RotatableStrings
    {
        public static void isRotation(string a,
                               string b)
        {
            int n = a.Length;
            int m = b.Length;
            if (n != m)
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

            i = 0;

            // match from that rotating point 
            for (int k = lps[n - 1]; k < m; ++k)
            {
                if (b[k] != a[i++])
                {
                    Console.WriteLine(0);
                    return;
                }
            }

            Console.WriteLine(1);
        }

        public static void isRotation1(string a,
                               string b)
        {
            string str = a + a;

            if (a.Length== b.Length && str.IndexOf(b) != -1)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
