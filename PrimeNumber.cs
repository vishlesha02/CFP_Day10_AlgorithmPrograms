using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAndSorting
{
    internal class PrimeNumber
    {
      
        public void Prime()
        {
            for (int i = 1; i <= 100; i++)
            {
                int temp = 0;

                for (int j = 2; j < i - 1; j++)
                {
                    if (i % j == 0)
                    {
                        temp = temp + 1;
                    }

                }
                if (temp == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
