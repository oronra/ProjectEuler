using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjEuler
{
    class P1
    {
        int sum = 0;
        public void MySoln()
        {
            for (int i = 0; i < 1000; i++)
            {
                if(i%3 == 0 || i % 5 == 0)
                {
                    sum = sum + i;
                }

            }
            Console.WriteLine(sum);
        }

        public void Better()
        {
            Library library = new Library();
            int three = library.SumDivisibleBy(3, 1000);
            int five = library.SumDivisibleBy(5, 1000);
            int fifteen = library.SumDivisibleBy(15, 1000);
            Console.WriteLine(three + five - fifteen);
        }
    }
}
