using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class ExtractMaximum
    {
        public static void fnExtractMaximum(string str)
        {
            string tempStr = string.Empty;
            var max = 0;
            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] >= 97 && str[i] <= 122)
                {
                    if (!string.IsNullOrWhiteSpace(tempStr))
                    {
                        var num = Convert.ToInt32(tempStr);
                        max = Math.Max(num, max);
                        tempStr = string.Empty;
                    }
                }
                else
                {
                    tempStr += (char)str[i];
                }
            }

            if (!string.IsNullOrWhiteSpace(tempStr))
            {
                var num = Convert.ToInt32(tempStr);
                max = Math.Max(num, max);
                tempStr = string.Empty;
            }

            Console.WriteLine(max);
        }

        public static void extractMaximum(String str)
        {
            int num = 0, res = 0;

            // Start traversing the given string 
            for (int i = 0; i < str.Length; i++)
            {

                // If a numeric value comes, start  
                // converting it into an integer  
                // till there are consecutive 
                // numeric digits 
                if (char.IsDigit(str[i]))
                    num = num * 10 + (str[i] - '0');

                // Update maximum value 
                else
                {
                    res = Math.Max(res, num);

                    // Reset the number 
                    num = 0;
                }
            }

            // Return maximum value 
            Console.WriteLine(Math.Max(res, num));
        }
    }
}
