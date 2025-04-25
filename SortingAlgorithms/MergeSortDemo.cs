using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.SortingAlgorithms
{
    public class MergeSortDemo
    {
        public static int[] MergeSort(int[] array)
        {

            if (array.Length <= 1)
                return array;
            
            int mid = array.Length / 2;

            int[] left = new int[mid];
            int[] right = new int[array.Length -mid];

            Array.Copy(array, 0, left, 0, mid);
            Array.Copy(array, mid, right, 0, array.Length - mid);



            MergeSort(left);
            MergeSort(right);




            Merge(array,left,right);

            return array;
        }

        private static void Merge(int[] array, int[] left, int[] right) {

            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if(left[i] <= right[j])
                {
                    array[k++] = left[i++];
                }
                else
                {
                    array[k++] = right[j++];
                }
            }

            while (i < left.Length)
            {
                array[k++] = left[i++];
            }

            while(j < right.Length)
            {
                array[k++] = right[j++];
            }
        }


    }
}
