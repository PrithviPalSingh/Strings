using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Anagram
    {
        public static void fnAnagram(string a, string b)
        {
            int[] arr = new int[26];

            for (int i = 0; i < a.Length; i++)
            {
                arr[a[i] - 'a']++;
                arr[b[i] - 'a']--;
            }

            //for (int i = 0; i < b.Length; i++)
            //{
            //    arr[b[i] - 'a']--;
            //}

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            Console.WriteLine("YES");
        }
    }
}
