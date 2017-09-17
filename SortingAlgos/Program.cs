using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;

namespace SortingAlgos
{
    internal class Program
    {
        public static void GenerateArray(int[] array, int[] sortedArray, Random rnd, int arraySizes)
        {
            // Generate some random test data
            for (int i = 0; i < arraySizes; i++)
            {
                array[i] = rnd.Next();
            }
            Console.WriteLine("Generated random numbers!");
            
            // Copy and sort array
            Array.Copy(array, sortedArray, arraySizes);
            Array.Sort(sortedArray);
        }

        public static bool ArrayEqual(int[] first, int[] second)
        {
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != second[i])
                {
                    Console.WriteLine("Not equal, index " + i);
                    return false;
                }
            }
            return true;
        }
        
        public static void Main(string[] args)
        {
            // Create our initial variables
            int arraySizes = 10;
            Random rnd = new Random();
            int[] array = new int[arraySizes];
            int[] sortedArray = new int[arraySizes];
            
            // Generate some random numbers
            GenerateArray(array, sortedArray, rnd, arraySizes);
            
            // Check that the sorted array and main array are not equal
            if (ArrayEqual(array, sortedArray) == false)
            {
                Console.WriteLine("Done checking numbers");
            }
            
            // Complete BubbleSort test
            BubbleSort.Sort(array);
            ArrayEqual(array, sortedArray);
            Console.WriteLine("BubbleSort finished");
        }
    }
}