using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAndSorting
{
    internal class BubbleSort
    {
        public void BuSort()
        {
            int temp = 0;
            int[] a = {5,6,8,3,4,2,1 };

            Console.WriteLine("Array");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < a.Length; i++)
            {
                int flag = 0;
                for (int j = 0; j < a.Length-1-i; j++)
                {
                    if (a[j] > a[j + 1])
                    { 
                        temp = a[j];
                        a[j] = a[j+1];
                        a[j+1] = temp;
                        
                        flag = 1;
                    }
                }

                if (flag == 0)
                {
                    break;
                }
            }
            Console.WriteLine("Sorted array");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            
            }
            Console.WriteLine();
        }
    }
}
