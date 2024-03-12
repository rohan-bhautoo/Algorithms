using System;

public class BubbleSortAlgorithm
{
    public static void Main(string[] args)
    {
        int[] arr1 = {2, 0, 6, 9, 1, 8, 4};
        BubbleSort(arr1);
        
        PrintArray(arr1);
    }
    
    public static void BubbleSort(int[] arr)
    {
        int N = arr.Length;
        
        for(int i = 0; i < N - 1; i++)
        {
            for(int j = 0; j < N - 1 - i; j++) 
            {
                if(arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
    
    public static void PrintArray(int[] arr)
    {
        foreach (var element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
