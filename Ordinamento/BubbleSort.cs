using System;

namespace Ordinamento
{
    public class BubbleSort
    {
        public static int[] Bubble_Sort(int[] array)
        {
            for (int x = 0; x < array.Length - 1; x++)
            {
                for (int y = 0; y < array.Length - 1; y++)
                {
                    if (array[y] > array[y + 1])
                    {
                        int temp = array[y];
                        array[y] = array[y + 1];
                        array[y + 1] = temp;
                    }
                }
            }
            return array;
        }
    }
}
