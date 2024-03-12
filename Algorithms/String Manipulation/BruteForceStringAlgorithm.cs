using System;

public class BruteForceStringAlgorithm
{
    public static void Main(string[] args)
    {
        string text = "ABABDABACDABABCABAB";
        string pattern = "ABABCABAB";

        Console.WriteLine("Brute Force:");
        BruteForceStringMatch(text, pattern);
    }
    
    public static void BruteForceStringMatch(string text, string pattern)
    {
        int N = text.Length;
        int M = pattern.Length;
        
        for(int i = 0; i <= N - M; i++)
        {
            int j;
            for(j = 0; j < M; j++)
            {
                if(text[i + j] != pattern[j])
                    break;
            }
            
            if(j == M)
                Console.WriteLine($"Pattern found at index {i}");
        }
    }
}
