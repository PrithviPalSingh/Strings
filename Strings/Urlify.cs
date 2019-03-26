using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Urlify
    {
        public static void fnUrlify(string str)
        {
            Stack<char> st = new Stack<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (st.Count == 0 && str[i] == 32)
                    continue;

                st.Push((char)str[i]);
            }

            while (st.Peek() == ' ')
            {
                st.Pop();
            }

            string newStr = string.Empty;

            while (st.Count > 0)
            {
                var pop = st.Pop();

                if (pop == ' ')
                    newStr += "02%";
                else
                    newStr += pop;
            }

            for (int i = newStr.Length - 1; i >= 0; i--)
            {
                Console.Write((char)newStr[i]);
            }

            Console.WriteLine();
        }

        public static void fnUrlify2(string str)
        {
            int spaceCount = 0, i = 0;

            for (i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    spaceCount++;
            }

            while (str[i - 1] == ' ')
            {
                spaceCount--;
                i--;
            }

            int newLength = i + (2 * spaceCount) + 1;
            int index = newLength - 1;
            for (int j = i - 1; j >= 0; j--)
            {
                if (str[j] == ' ')
                {
                    //str[index] = '0';
                    //str[index - 1] = '%';
                    //str[index - 2] = '2';
                    index -= 3;
                }
                else
                {
                    //str[index] = str[j];
                    index--;
                }
            }

            Console.WriteLine(str);
        }
    }
}
