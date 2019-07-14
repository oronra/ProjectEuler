using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjEuler
{
    class Problems
    {
        public void P2SumFibo(int limit)
        {
            int one, two, three;
            int fibosum = 2;
            one = 1;
            two = 2;
            for (int i = 3; fibosum < limit; i++)
            {
                three = one + two;
                if (three % 2 == 0) { fibosum += three; }
                one = two;
                two = three;
            }
            Console.WriteLine(fibosum);
        }

        public void P3LargestPrimeFactor(long number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    number = number / i;
                    i--;
                }

            }
            Console.WriteLine(number);
        }

        public void P4LargestPalindrome()
        {
            //largest number from multiplying 3 digit numbers would be below 1000 * 1000 = 1,000,000. i.e. six digits. So I just need to compare first 3 with reversal of last 3
            // really good way to solve this is here: https://www.xarg.org/puzzle/project-euler/problem-4/

            List<int> Palindromes = new List<int>();

            for (int a = 0; a < 999; a++)
            {
                for (int b = 0; b < a; b++)
                {
                    int product = a * b;
                    string txt1 = product.ToString();
                    if (Library.IsPalindrome(txt1))
                    {
                        Palindromes.Add(product);
                    }
                }
            }
            
            Console.WriteLine(Palindromes.Max());
        }

        
    }
}
