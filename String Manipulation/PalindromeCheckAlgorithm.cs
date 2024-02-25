using System;

public class PalindromeCheckAlgorithm
{
    public static void Main(string[] args)
    {
        string palindromeString = "A man, a plan, a canal, Panama!";
        bool isPalindrome = IsPalindrome(palindromeString);

        Console.WriteLine($"Is the string '{palindromeString}' a palindrome? {isPalindrome}");
    }
    
    public static bool IsPalindrome(string input)
    {
        // Convert the string to lowercase for case-insensitive comparison
        input = input.ToLower();
            
        int start = 0;
        int end = input.Length - 1;
        
        while(start < end)
        {
            // Skip non-alphanumeric characters from the beginning
            while (start < end && !char.IsLetterOrDigit(input[start]))
            {
                start++;
            }

            // Skip non-alphanumeric characters from the end
            while (start < end && !char.IsLetterOrDigit(input[end]))
            {
                end--;
            }

            // Compare characters at corresponding positions
            if (input[start] != input[end])
            {
                return false; // Not a palindrome
            }
            
            start++;
            end--;
        }
        
        return true;
    }
}
