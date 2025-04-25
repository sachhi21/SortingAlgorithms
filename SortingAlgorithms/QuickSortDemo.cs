using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.SortingAlgorithms
{
    public class QuickSortDemo
    {
        public static int[] QuickSort(int[] ints, int low, int high)
        {

            if (low < high)

            {
                int pivot = Partion(ints, low, high);
                QuickSort(ints, low, pivot -1);
                QuickSort(ints, pivot + 1, high);


            }

            return ints;
        }

        private static  int Partion(int[] ints, int low, int high)
        {
            int pivot = ints[high];

            int i = low - 1;

            for (int j = low; j <= high - 1; j++)
            {

                if( ints[j] < pivot)
                {
                    i++;
                    swap(ints, i, j);
                }

            }
            swap(ints, i +1, high);
            return i + 1;

        }

        private static void swap(int[] ints, int i, int j)
        {
            int temp = ints[i];
            ints[i] = ints[j];
            ints[j] = temp;
        }

    }
}
