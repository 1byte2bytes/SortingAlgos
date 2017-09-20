using System;
using System.Collections.Generic;

namespace SortingAlgos
{
    public class CombSort
    {
        private static bool sorted;

        public static void Sort(int[] input)
        {
            double gap = input.Length;
            double shrink = 1.3;

            while (sorted == false)
            {
                gap = Math.Floor(gap / shrink);
                if (gap > 1)
                {
                    sorted = false;
                }
                else
                {
                    gap = 1;
                    sorted = true;
                }

                for (int i = 0; i + gap < input.Length; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        int temp = input[i + 1];
                        input[i + 1] = input[i];
                        input[i] = temp;
                        sorted = false;
                    }
                }
            }
        }
    }
}