using System;

public class FindMaximumAlgorithm
{
    public static void Main(string[] args)
    {
        int[] arr1 = {2, 0, 6, 9, 1, 8, 4};
        Console.WriteLine(FindMaximum(arr1));
    }
    
    public static int FindMaximum(int[] arr)
    {
        int N = arr.Length;
        int max = int.MinValue;
        
        for(int i = 0; i < N; i++)
        {
            if(arr[i] > max)
                max = arr[i];
        }
        
        return max;
    }
}
