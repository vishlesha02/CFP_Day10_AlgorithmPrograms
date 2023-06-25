using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAndSorting
{
    internal class InsertionSort
    {
        public void InSort()
        {
            int[] a = { 5, 6, 3, 8, 7, 2 };

            Console.WriteLine("Array List");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();


            for (int i = 1; i < a.Length; ++i)
            {
                int key = a[i];
                int j = i;
                while (j > 0 && a[j-1] > key)
                {
                    a[j]  = a[j-1];
                    j = j - 1;
                }
                a[j] = key;
            }

            Console.WriteLine("Sorted Array : ");
            for (int i = 0; i < a.Length; ++i)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
