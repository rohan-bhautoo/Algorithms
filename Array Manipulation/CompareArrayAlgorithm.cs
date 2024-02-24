using System;

public class CompareArrayAlgorithm
{
    public static void Main(string[] args)
    {
        int[] arr1 = {2, -2, 6, 9, 1, 8, 4};
        int[] arr2 = {4, 1, 8, -2, 9, 6, 2};
        Console.WriteLine(areEqual(arr1, arr2));
    }
    
    public static bool areEqual(int[] arr1, int[] arr2)
    {
        int N = arr1.Length;
        int M = arr2.Length;
        
        if(N != M)
            return false;
            
        BubbleSort(arr1);
        BubbleSort(arr2);
        
        for(int i = 0; i < N; i++)
        {
            if(arr1[i] != arr2[i])
                return false;
        }
        
        return true;
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
}
