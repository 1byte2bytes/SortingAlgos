using System;

namespace SortingAlgos
{
    public class BubbleSort
    {
        public static void Sort(int[] input)
        {
            int len = input.Length;
            bool swapped = true;
            while (swapped == true)
            {
                swapped = false;
                for (int i = 1; i <= len - 1; i++)
                {
                    if (input[i - 1] > input[i])
                    {
                        int temp = input[i - 1];
                        input[i - 1] = input[i];
                        input[i] = temp;
                        swapped = true;
                    }
                }
            }
        }
    }
}