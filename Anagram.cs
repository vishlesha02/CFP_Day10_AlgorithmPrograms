using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAndSorting
{
    internal class Anagram
    {
        public void Word()
        {
            Console.WriteLine("Enter 1st word");
            String str1 = Console.ReadLine();   

            Console.WriteLine("Enter 2nd word");
            String str2 = Console.ReadLine();

            if (str1.Length != str2.Length)
            {
                Console.WriteLine("It is not an Anagram");
                return;
            }
            
            char[] word1 = str1.ToLower().ToCharArray();
            char[] word2 = str2.ToLower().ToCharArray();


            Array.Sort(word1);
            Array.Sort(word2);

            for (int i=0; i < word1.Length; i++ )
            {
                if (word1[i] != word2[i])
                {
                    Console.WriteLine("It is not an Anagram");
                    return;
                }
            }
            Console.WriteLine("It is ana Anagram");

        }
    }
}
