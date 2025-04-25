// See https://aka.ms/new-console-template for more information
using SortingAlgorithms.SortingAlgorithms;

public class Program
{
    public static void Main(string[] args)
    {
        BubbleSortDemo.BubbleSort(new int[] { 7,3,5,6,9,1});
        InsertionSortDemo.InsertionSort(new int[] { 7, 3, 5, 6, 9, 1 });
        SelectionSortDemo.SelectionSort(new int[] { 7, 3, 5, 6, 9, 1 });
        int[] arr = { 5, 3, 8, 4, 2 };
        arr = MergeSortDemo.MergeSort(arr);
        HeapSortDemo.BuildMaxHeap(new int[]  { 5, 3, 8, 4, 2 });




    }
}