using System;

public class BruteForceStringAlgorithm
{
    public static void Main(string[] args)
    {
        string text = "ABABDABACDABABCDABAB";
        string pattern = "CD";

        Console.WriteLine("Knuth-Morris-Pratt (KMP):");
        KMPSearch(text, pattern);
    }
    
    public static void KMPSearch(string text, string pattern)
    {
        int n = text.Length;
        int m = pattern.Length;

        int[] lps = ComputeLPSArray(pattern);

        int i = 0, j = 0;
        while (i < n)
        {
            if (pattern[j] == text[i])
            {
                j++;
                i++;
            }

            if (j == m)
            {
                Console.WriteLine($"Pattern found at index {i - j}");
                j = lps[j - 1];
            }
            else if (i < n && pattern[j] != text[i])
            {
                if (j != 0)
                    j = lps[j - 1];
                else
                    i++;
            }
        }
    }

    private static int[] ComputeLPSArray(string pattern)
    {
        int m = pattern.Length;
        int[] lps = new int[m];

        int len = 0, i = 1;
        while (i < m)
        {
            if (pattern[i] == pattern[len])
            {
                len++;
                lps[i] = len;
                i++;
            }
            else
            {
                if (len != 0)
                    len = lps[len - 1];
                else
                {
                    lps[i] = 0;
                    i++;
                }
            }
        }
        return lps;
    }
}
