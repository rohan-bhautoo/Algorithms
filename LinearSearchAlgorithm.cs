using System;

public class LinearSearchAlgorithm
{
    public static void Main(string[] args)
    {
        int[] arr = { 10, 8, 1, 6, 2, 9, 4 };
        
        Console.WriteLine(LinearSearch(arr, 2));
    }
    
    public static int LinearSearch(int[] arr, int target)
    {
        int N = arr.Length;
        
        for(int i = 0; i < N; i++)
        {
            if(arr[i] == target)
                return i;
        }
        
        return -1; // if target not found
    }
}
