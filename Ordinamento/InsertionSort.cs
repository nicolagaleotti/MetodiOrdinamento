using System;
using System.Collections.Generic;
using System.Text;

namespace Ordinamento
{
    public class InsertionSort
    {
        public static int[] Insertion_Sort(int[] array)
        {
            int flag;
            int val;
            for (int i = 1; i < array.Length; i++)
            {
                val = array[i];
                flag = i - 1;
                while(flag >= 0 && array[flag] > val)
                {
                    array[flag + 1] = array[flag];
                    flag--;
                }
                array[flag + 1] = val;
            }
            return array;
        }
    }
}
