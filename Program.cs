﻿using SearchingAndSorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    internal class Program
    {
        public static void Main(string[] args) 
        {
            PrimeNumber obj =new PrimeNumber();
            Console.WriteLine("1 to 100 Prime Numbers : ");
            obj.Prime();
            Console.WriteLine();

            Anagram obj2=new Anagram();
            Console.WriteLine("Check the Anagram ");
            obj2.Word();
            Console.WriteLine();

            BubbleSort obj3=new BubbleSort();
            Console.WriteLine("Bubble Sort : ");
            obj3.BuSort();
            Console.WriteLine();

            InsertionSort obj4 = new InsertionSort();
            Console.WriteLine("Insertion Sort : ");
            obj4.InSort();
            Console.WriteLine();

            BinarySearch obj5=new BinarySearch();
            Console.WriteLine("Binary Search : ");
            obj5.BiSearch();
            Console.WriteLine();
        }
    }
}
