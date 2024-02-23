using System;

public class SumAverageAlgorithm
{
    public static void Main(string[] args)
    {
        int[] arr = {1, 2, 3};
        Console.WriteLine (ComputeSum(arr));
        Console.WriteLine (ComputeAverage(arr));
    }
    
    public static int ComputeSum(int[] arr)
    {
        int N = arr.Length;
        int sum = 0;
        
        for(int i = 0; i < N; i++)
        {
            sum += arr[i];
        }
        
        return sum;
    }
    
    public static double ComputeAverage(int[] arr)
    {
        int N = arr.Length;
        int sum = ComputeSum(arr);
        
        return (double)sum / N;
    }
}
