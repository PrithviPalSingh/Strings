using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class SortStringDescendingOrder
    {
        public static void fnSortInDescendingOrder(string str)
        {
            int[] alplabets = new int[26];

            for (int i = 0; i < str.Length; i++)
            {
                alplabets[str[i] - 'a']++;
            }

            for (int i = alplabets.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < alplabets[i]; j++)
                {
                    Console.Write((char)(i + 'a'));
                }
            }

            Console.WriteLine();
        }
    }
}
