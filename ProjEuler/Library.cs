using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjEuler
{
    class Library
    {
        public int SumDivisibleBy(int number, int target)
        {
            int p = (target-1) / number;
            return ((number * p * (p + 1)) / 2);
        }

        public static bool IsPalindrome(string txt1)
        {
            char[] txt2 = new char[txt1.Length];

            for (int i = 0; i < txt1.Length; i++)
            {
                txt2[i] = txt1[txt1.Length - 1 - i];
            }
            string txt22 = new string(txt2);
            if (string.Equals(txt1, txt22))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
