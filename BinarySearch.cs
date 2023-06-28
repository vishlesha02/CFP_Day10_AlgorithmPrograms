using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAndSorting
{
    internal class BinarySearch
    {

        public void BiSearch()
        {
            int[] a = { 2, 4, 5, 6, 8, 9, 12, 13, 15, 18, 19, 20 };

            int li = 0;
            int hi = a.Length - 1;
            int mi = (li + hi) / 2;
            int search = 13;


            while (li <= hi)
            {
                if (a[mi] == search)
                {
                    Console.WriteLine($"Element is at {mi} index Position");
                    break;
                }

                else if (a[mi] < search)
                {
                    li = mi + 1;
                }
                else
                {
                    hi = mi - 1;
                }
                mi = (li + hi) / 2;
            }
            if (li > hi)
            {
                Console.WriteLine("Element not found");
            }
        
        }
    }
}
