## String Manipulation:

- Reverse a string or a sentence.
  <details><summary><b>Analysis</b></summary>
    
    1. <h2>Problem Statement</h2>
    
        - The goal is to reverse the characters in a string or the words in a sentence.
          
    2. <h2>Input</h2>
    
        - A string or sentence.
          
    2. <h2>Output</h2>
    
        - The reversed string or sentence.
          
    4. <h2>Algorithm</h2>
    
        1. Reverse String:
             - Start from both ends of the string.
             - Swap the characters at the two ends and move towards the center until the entire string is reversed.
      
                ```
                Lets break it down:

                string = "Hello"

                First Iteration:
                ('H','e','l','l','o') → ('o','e','l','l','H')

                Second Iteration:
                ('o','e','l','l','H') → ('o','l','l','e','H')

                final string = 'olleH'
                ```
                
        2. Reverse Sentence (Words):
             - Split the sentence into individual words.
             - Reverse the order of the words.
             - Join the reversed words to form the reversed sentence.
      
                ```
                Lets break it down:

                string = "This is a sentence."

                // Convert to Char array:
                ['T', 'h', 'i', 's', ' ', 'i', 's', ' ', 'a', ' ', 's', 'e', 'n', 't', 'e', 'n', 'c', 'e', '.']

                // Reverse the Entire Sentence:
                ['.', 'e', 'c', 'n', 'e', 't', 'n', 'e', 's', ' ', 'a', ' ', 's', 'i', ' ', 's', 'i', 'h', 'T']

                // Words are split using ' ' and then reversed
                ['s', 'e', 'n', 't', 'e', 'n', 'c', 'e', '.', ' ', 'a', ' ', 'i', 's', ' ', 'T', 'h', 'i', 's']

                final string = 'sentence. sample a is This'
                ```
    
    5. <h2>Time Complexity</h2>

          - For reversing a string, the time complexity is $O(N)$, where $N$ is the length of the string. This is because each character is visited once during the reversal process.
          - For reversing a sentence (words), the time complexity is also $O(N)$, where $N$ is the total number of characters in the sentence.

    6. <h2>Space Complexity</h2>

        - The space complexity for both cases is $O(1)$ since the reversal is performed in-place, and no additional space is required proportional to the size of the input.

    7. <h2>Optimizations</h2>

        - For reversing a sentence, the process can be optimized by reversing the entire string first and then reversing the individual words. This reduces the number of character swaps needed.
    
    </details>

    Code: [StringReversalAlgorithm.cs](https://github.com/rohan-bhautoo/Algorithms/blob/main/String%20Manipulation/StringReversalAlgorithm.cs)
  
- Check if a string is a palindrome.
  <details><summary><b>Analysis</b></summary>
    
    1. <h2>Problem Statement</h2>
    
        - The goal is to determine whether a given string is a palindrome. A palindrome is a string that reads the same forward as backward.
          
    2. <h2>Input</h2>
    
        - A string.
          
    2. <h2>Output</h2>
    
        - Returns true if the string is a palindrome. Otherwise, it will return false.
          
    4. <h2>Algorithm</h2>
    
        1. Iterate through the characters of the string from both ends simultaneously.
        2. Compare the characters at corresponding positions.
        3. If all pairs of corresponding characters match, the string is a palindrome.
      
                ```
                Lets break it down:

                string input = "A man, a plan, a canal, Panama!";

                // String converted to lowercase
                input = "a man, a plan, a canal, panama!";

                // Non-alphanumeric characters are skipped
                input = "amanaplanacanalpanama";

                // Two pointers are used, one at the beginning and one at the end of the processed string:
                'start' initially points to the first character ('a').
                'end' initially points to the last character ('a').

                //Iteration:
                Characters at the corresponding positions are compared:
                'a' (start) == 'a' (end) → Move pointers.
                'm' (start) == 'm' (end) → Move pointers.
                'a' (start) == 'a' (end) → Move pointers.

                // The algorithm continues comparing characters until the pointers meet in the middle.
                ```
    
    5. <h2>Time Complexity</h2>

          - The time complexity is $O(N)$, where $N$ is the length of the string. This is because we need to iterate through half of the string to check for palindrome property.

    6. <h2>Space Complexity</h2>

        - The space complexity is $O(1)$ since no additional space is used that scales with the size of the input.

    7. <h2>Optimizations</h2>

        - The algorithm can be optimized by ignoring non-alphanumeric characters and treating uppercase and lowercase letters as equal.
    
    </details>

    Code: [PalindromeCheckAlgorithm.cs](https://github.com/rohan-bhautoo/Algorithms/blob/main/String%20Manipulation/PalindromeCheckAlgorithm.cs)
  
- Find the first non-repeated character in a string.
  <details><summary><b>Analysis</b></summary>
    
    1. <h2>Problem Statement</h2>
    
        - The goal is to find the first non-repeated character in a given string.
          
    2. <h2>Input</h2>
    
        - A string.
          
    2. <h2>Output</h2>
    
        - The first non-repeated character in the string. Returns null if there's no non-repeated character.
          
    4. <h2>Algorithm</h2>
    
        1. Iterate through the string and count the occurrences of each character using a Dictionary.
        2. Find the first character with a count of 1.
      
    5. <h2>Time Complexity</h2>

          - The time complexity is $O(N)$, where $N$ is the length of the string. This is because we iterate through the string once to count the occurrences and then iterate again to find the first non-repeated character.
            
    6. <h2>Space Complexity</h2>

        - The space complexity is $O(k)$, where $k$ is the number of unique characters in the string. The algorithm uses a Dictionary to store the counts of each character.
    
    </details>

    Code: [FirstNonRepeatedCharAlgorithm.cs](https://github.com/rohan-bhautoo/Algorithms/blob/main/String%20Manipulation/FirstNonRepeatedCharAlgorithm.cs)
  
- Find the most repeated character in a string.
  <details><summary><b>Analysis</b></summary>
    
    1. <h2>Problem Statement</h2>
    
        - The goal is to find the character that appears most frequently in a given string.
          
    2. <h2>Input</h2>
    
        - A string.
          
    2. <h2>Output</h2>
    
        - The character that appears most frequently.
          
    4. <h2>Algorithm</h2>
    
        1. Iterate through the string and count the occurrences of each character using an array of counts.
        2. Find the character with the highest count.
      
    5. <h2>Time Complexity</h2>

          - The time complexity is $O(N)$, where $N$ is the length of the input string. This is because the string is iterated once to count the occurrences.
            
    6. <h2>Space Complexity</h2>

        - The space complexity is $O(1)$ since the size of the array (256 elements) is constant and independent of the input size.
    
    </details>

    Code: [RepeatedCharAlgorithm.cs](https://github.com/rohan-bhautoo/Algorithms/blob/main/String%20Manipulation/RepeatedCharAlgorithm.cs)
  
- Implement string matching algorithms.
