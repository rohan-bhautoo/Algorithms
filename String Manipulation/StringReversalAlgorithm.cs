using System;

public class StringReversalAlgorithm
{
    public static void Main(string[] args)
    {
        char[] originalCharArray = "Hello, World!".ToCharArray();
        ReverseString(originalCharArray, 0, originalCharArray.Length - 1);
        Console.WriteLine("Reversed String: " + new string(originalCharArray));

        string originalSentence = "This is a sample sentence.";
        string reversedSentence = ReverseSentence(originalSentence);
        Console.WriteLine("Reversed Sentence: " + reversedSentence);
    }
    
    public static string ReverseString(char[] charArray, int start, int end)
    {
        while(start < end)
        {
            // Swap characters at start and end indices
            char temp = charArray[start];
            charArray[start] = charArray[end];
            charArray[end] = temp;
            
            start++;
            end--;
        }
        
        return new string(charArray);
    }
    
    public static string ReverseSentence(string sentence)
    {
        char[] charArray = sentence.ToCharArray();
        
        // Reverse entire sentence
        ReverseString(charArray, 0, charArray.Length - 1);
        
        // Reverse individual words
        int start = 0;
        for(int end = 0; end < charArray.Length; end++)
        {
            if(charArray[end] == ' ')
            {
                ReverseString(charArray, start, end - 1);
                start = end + 1;
            }
        }
        
        // Reverse the last word
        ReverseString(charArray, start, charArray.Length - 1);

        return new string(charArray);
    }
}
