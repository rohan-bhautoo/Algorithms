using System;
using System.Collections.Generic;

public class FirstNonRepeatedCharAlgorithm
{
    public static void Main(string[] args)
    {
        string inputString = "abaccabaddv";
        char? firstNonRepeated = FindFirstNonRepeatedCharacter(inputString);

        if (firstNonRepeated.HasValue)
        {
            Console.WriteLine("The first non-repeated character is: " + firstNonRepeated);
        }
        else
        {
            Console.WriteLine("No non-repeated character found in the string.");
        }
    }
    
    public static char? FindFirstNonRepeatedCharacter(string input)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        HashSet<char> repeatedChars = new HashSet<char>();
        
        foreach(char c in input)
        {
            // If the character is already repeated, skip it
            if(repeatedChars.Contains(c))
                continue;
                
            // Update the count of each character
            if(charCount.ContainsKey(c))
            {
                charCount[c]++;
                repeatedChars.Add(c);
            }
            else
            {
                charCount[c] = 1;
            }
        }
        
        // Find the first non-repeated character
        foreach(char c in input)
        {
            if(!repeatedChars.Contains(c))
                return c;
        }
        
        return null; // No non-repeated character found
    }
}
