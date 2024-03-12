using System;

public class FindMinimumAlgorithm
{
    public static void Main(string[] args)
    {
        int[] arr1 = {2, -2, 6, 9, 1, 8, 4};
        Console.WriteLine(FindMinimum(arr1));
    }
    
    public static int FindMinimum(int[] arr)
    {
        int N = arr.Length;
        int min = int.MaxValue;
        
        for(int i = 0; i < N; i++)
        {
            if(arr[i] < min)
                min = arr[i];
        }
        
        return min;
    }
}
