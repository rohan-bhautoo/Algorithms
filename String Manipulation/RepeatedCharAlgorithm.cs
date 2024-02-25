using System;

public class RepeatedCharAlgorithm
{
    public static void Main(string[] args)
    {
        string str = "AAOABBCCHOOOIIOOOIIDEEFFGGGI";
        Console.WriteLine(FindMostRepeatedChar(str));
    }
    
    public static char FindMostRepeatedChar(string input)
    {
        int[] charCountArray = new int[256];
        
        foreach(char c in input) 
        {
            charCountArray[c]++;
        }
        
        char mostRepeatedChar = ' ';
        int maxCount = 0;
        
        for(int i = 0; i < charCountArray.Length; i++)
        {
            if(charCountArray[i] > maxCount)
            {
                mostRepeatedChar = (char)i;
                maxCount = charCountArray[i];
            }
        }
        
        return mostRepeatedChar;
    }
}
