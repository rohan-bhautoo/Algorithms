using System;

public class BinarySearchAlgorithm
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 4, 5, 7, 8, 9, 10 };
        
        Console.WriteLine(BinarySearch(arr, 4));
    }
    
    public static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;
        
        while(left <= right)
        {
            int mid = left + (right - left) / 2;
            
            if (arr[mid] == target)
                return mid; // Return the index if target found
            
            if(arr[mid] < target)
                left = mid + 1; // Discard left half
            else
                right = mid - 1; // Discard right half
        }
        
        return -1; // if target not found
    }
}
