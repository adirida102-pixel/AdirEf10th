using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdirEf10th
{
    public class ArraySort
    {
        public static void Sort_UnitTest()
        {
            int[] arr1 = {3, 0, 1, 8, 7, 2, 5, 4, 9, 6};
            int[] arr2 = {4, 12, 56, 102, 33, 6, 2763, 11, -2, -86, 0};
            BubbleSort(arr1);
            BubbleSort(arr2);
            for (int i = 0; i < arr1.Length - 1; i++)
            {
                Console.Write($"{arr1[i]}, ");
            }
            Console.WriteLine(arr1[arr1.Length - 1]);
            for (int i = 0; i < arr2.Length - 1; i++)
            {
                Console.Write($"{arr2[i]}, ");
            }
            Console.WriteLine(arr2[arr2.Length - 1]);
        }
        
        public static void BubbleSort(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }
    }
}
