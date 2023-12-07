using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_valued_odd
{
    internal class Solution2
    {
        public string LargestOddNumber(string num)
        {
            Sl(ref num);
            return num;
        }
        public void Sl(ref string num)
        {
            char[] c = num.ToCharArray();
            while (c.Length!=0)
            {
                if (int.Parse(c[c.Length - 1].ToString()) % 2 != 0)
                {
                    num = new string(c);
                    break;
                }
                else
                {
                    RemoveLast(ref c);
                    num = "";
                }
            }

           
        }

        public void RemoveAt<T>(ref T[] arr, int index)
        {
            T[] newArray = new T[arr.Length - 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = arr[i];
            }
            for (int i = index + 1; i < arr.Length; i++)
            {
                newArray[i - 1] = arr[i];
            }
            arr = newArray;
        }
        public void RemoveLast<T>(ref T[] array)
        {
            RemoveAt<T>(ref array, array.Length - 1);
        }

    }
}
