using System;

namespace SortingAlgos
{
    public class ShakerSort
    {
        public static void Sort(int[] input)
        {
            int len = input.Length;
            bool swapped = true;

            while (swapped == true)
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

                if (swapped == false)
                {
                    return;
                }

                swapped = false;
                
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
                
                if (swapped == false)
                {
                    return;
                }
            }
        }
    }
}