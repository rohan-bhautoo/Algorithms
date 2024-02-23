using System;

public class ArrayRotationAlgorithm
{
    public static void Main(string[] args)
    {
        int[] arr1 = { 1, 2, 3, 4, 5, 6, 7 };
        int rotations = 1;

        // Example of left rotation
        RotateLeft(arr1, rotations);
        Console.WriteLine("Array after left rotation: " + string.Join(", ", arr1));

        int[] arr2 = { 1, 2, 3, 4, 5, 6, 7 };
        // Example of right rotation
        RotateRight(arr2, rotations);
        Console.WriteLine("Array after right rotation: " + string.Join(", ", arr2));
    }
    
    public static void ReverseArray(int[] arr, int start, int end)
    {
        while(start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
    }
    
    public static void RotateLeft(int[] arr, int d)
    {
        int N = arr.Length;
        d = d % N; // Handle cases where d is greater than the array size
        
        // Reverse the first d elements
        ReverseArray(arr, 0, d - 1);
        
        // Reverse the remaining elements
        ReverseArray(arr, d, N - 1);
        
        // Reverse the entire array
        ReverseArray(arr, 0, N - 1);
    }
    
    public static void RotateRight(int[] arr, int d)
    {
        int N = arr.Length;
        d = d % N; // Handle cases where d is greater than the array size
    
        // Reverse the entire array
        ReverseArray(arr, 0, N - 1);
    
        // Reverse the first d elements
        ReverseArray(arr, 0, d - 1);
    
        // Reverse the remaining elements
        ReverseArray(arr, d, N - 1);
    }
}
