using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class UppercaseConversion
    {
        public static void fnConvertToUpperCase(string str)
        {
            string newStr = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if ((i==0 ||(i>0 && str[i-1] == 32)) &&str[i] >= 97 && str[i] <= 122)
                {                    
                    newStr += Convert.ToChar(str[i] - 32);
                }
                else {
                    newStr += str[i];
                }
            }

            Console.WriteLine(newStr);
        }
    }
}
