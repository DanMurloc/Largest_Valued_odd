using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_valued_odd
{
    internal class Solution
    {
        public string LargestOddNumber(string num)
        {
            Chet(ref num);
            return num;
        }

        public void Chet(ref string num)
        {
            long a = long.Parse(num);
            if (a % 2 == 0)
            {
                StChets(ref num);
            }
           
        }
        public void StChets(ref string num)
        {
            string a = num;
            string b = num;
            string Max1 = "";
            string Max2 = "";
            for (int i = num.Length-1; i > 0; i--)
            {
                if (long.Parse(a) % 2 == 0)
                {
                    a = a.Remove(i, 1);
                }
            }
            Max1 = a;
            for (int i = 0; i < num.Length; i++)
            {
                if (long.Parse(b) % 2 == 0)
                {
                    b = b.Remove(0, 1);
                }
            }
            Max2 = b;
            string max = num;
            if ((Max1 == "" && Max2 == "") || (long.TryParse(Max2, out var parsedNumber) && long.TryParse(Max1, out var parsedNumber2)))
            {
                StChet(ref max);
            }
            else if ((long.TryParse(Max2, out var parsedNumber3) && long.TryParse(Max1, out var parsedNumber4)) && (long.Parse(Max2) > long.Parse(Max1)))
            {
                max = Max2;
            }
            else if ((long.TryParse(Max2, out var parsedNumber5) && long.TryParse(Max1, out var parsedNumber46)) && (long.Parse(Max2) < long.Parse(Max1)))
            {
                max = Max1;
            }
            else if ((Max1 == "") && long.Parse(Max2)%2 !=0)
            {
                max = Max2;
            }
            else if ((Max1 == "") && long.Parse(Max2) % 2 == 0)
            {
                StChet(ref max);
            }
            else if((Max2 == "") && long.Parse(Max1) % 2 == 0)
            {
                StChet(ref max);
            }
            else if (Max2 == ""&& long.Parse(Max1) % 2 != 0)
            {
                max = Max1;
            }
            num = max;

        }
        public void StChet(ref string num)
        {
            char[] c = num.ToCharArray();
            string Max = "";
            int l = 1;
            for (int i = 0; i < c.Length; i++)
            {
                int a = int.Parse(c[i].ToString());
                if (a % 2 != 0)
                {
                    if (Max == "")
                        l = a;
                    if (l <= a)
                        l = a;
                    Max = l.ToString();
                }
            }
            if (Max=="")
            {
                num = "";
            }
            else if (int.Parse(Max) % 2 ==0)
            {
                num = "";
            }
            else
            num = Max;
        }
    }
}
