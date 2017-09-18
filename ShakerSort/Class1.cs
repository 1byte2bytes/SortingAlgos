using System;

namespace SortingAlgos
{
    public class ShakerSort
    {
        private static bool swapped = true;
        
        public static void Sort(int[] input)
        {
            int len = input.Length;

            while (swapped)
            {
                swapped = false;
                
                for (int i = 0; i < len - 2; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        int temp = input[i + 1];
                        input[i + 1] = input[i];
                        input[i] = temp;
                        swapped = true;
                    }
                }

                // If nothing was changed, return
                if (swapped == false) return;
                
                for (int i = len - 2; i > 0; i--)
                {
                    if (input[i] > input[i + 1])
                    {
                        int temp = input[i + 1];
                        input[i + 1] = input[i];
                        input[i] = temp;
                        swapped = true;
                    }
                }
            }
        }
    }
}