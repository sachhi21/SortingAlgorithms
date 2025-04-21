// See https://aka.ms/new-console-template for more information
using SortingAlgorithms.SortingAlgorithms;

public class Program
{
    public static void Main(string[] args)
    {
        BubbleSortDemo.BubbleSort(new int[] { 7,3,5,6,9,1});
        InsertionSortDemo.InsertionSort(new int[] { 7, 3, 5, 6, 9, 1 });
        SelectionSortDemo.SelectionSort(new int[] { 7, 3, 5, 6, 9, 1 });


    }
}