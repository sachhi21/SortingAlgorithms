using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.SortingAlgorithms
{
    public class HeapSortDemo
    {
        public static void MaxHeapify(int[] arr,int n, int i)
        {

            int root = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

           if (left < n && arr[left] > arr[root] )
            {
                root = left;
            }

            if ( right < n && arr[right] > arr[root])
            {
                root = right;
            }

            if (root != i)
            {
                int temp = arr[i];
                arr[i] = arr[root];
                arr[root] = temp;

                MaxHeapify(arr, n, root);
            }


        }

        static void PrintArray(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }


        public static void BuildMaxHeap(int[] arr)
        {
            int n = arr.Length;

            // Start from the last non-leaf node and call MaxHeapify for each node
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                MaxHeapify(arr, n, i);
            }

            PrintArray(arr);

            for (int i = n - 1; i > 0; i--)
            {
                // Swap the root (maximum element) with the last element
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // Call MaxHeapify on the reduced heap
                MaxHeapify(arr, i, 0);
            }


        }
    }
}
