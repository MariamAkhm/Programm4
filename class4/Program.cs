using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class4
{
    class Program
    {
        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        static int Partion(int[] array, int start, int end)
        {
            int supportPoint = array[start];
            int swapIndex = start;
            for (int i = start + 1; i < end; i++)
            {
                if (array[i] < supportPoint)
                {
                    swapIndex++;
                    Swap(array, i, swapIndex);
                }
            }
            Swap(array, start, swapIndex);
            return swapIndex;
        }
        static int[] QuickSort(int[] array, int start, int end)
        {
            if (start < end)
            {
                int supportPoint = Partion(array, start, end);
                QuickSort(array, start, supportPoint);
                QuickSort(array, supportPoint + 1, end);
            }
            return array;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            int[] unSortedArray = new int[10];
            Random r = new Random();
            for (int i = 0; i < unSortedArray.Length; i++)
            {
                unSortedArray[i] = r.Next(100);
            }

            for (int i = 0; i < unSortedArray.Length; i++)
            {
                Console.WriteLine(unSortedArray[i]);
            }
            int[] sortedArray = QuickSort(unSortedArray, 0, unSortedArray.Length);
            Console.WriteLine();
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.WriteLine(sortedArray[i]);
            }

        }
    }
}
