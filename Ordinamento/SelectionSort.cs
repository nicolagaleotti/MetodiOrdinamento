using System;
using System.Collections.Generic;
using System.Text;

namespace Ordinamento
{
    public class SelectionSort
    {
        public static int[] Selection_Sort(int[] array)
        {
            int i_min;
            int temp;
            for (int x = 0; x < array.Length - 1; x++)
            {
                i_min = x;
                for (int y = x + 1; y < array.Length; y++)
                {
                    if (array[y] < array[i_min])
                    {
                        i_min = y;
                    }
                }
            }
            return array;
        }
    }
}
