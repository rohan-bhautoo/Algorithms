# Algorithmic Topics for Technical Interviews

Algorithm exercises in interviews can cover a wide range of topics, and the complexity can vary based on the role and the company. Here are some common algorithmic topics that you might encounter in a technical interview:

## Array Manipulation:

- Find the maximum/minimum element in an array.
  <details><summary><b>Analysis</b></summary>
    
    1. <h2>Problem Statement</h2>
    
        - Given an array of integers, find and return the maximum/minimum element in the array.
          
    2. <h2>Input</h2>
    
        - An array of integers of length $N$.
          
    2. <h2>Output</h2>
    
        - The maximum/minimum element in the array.
          
    4. <h2>Algorithm</h2>
    
        1. The algorithm iterates through the array once, keeping track of the maximum/minimum element found so far.
    
    5. <h2>Time Complexity</h2>

        - The algorithm iterates through the array once, making $N$ comparisons.
        - Therefore, the time complexity is $O(N)$, where $N$ is the size of the input array.

    6. <h2>Space Complexity</h2>

        - The algorithm uses only a constant amount of additional space to store the maximum/minimum element found so far.
        - Therefore, the space complexity is $O(1)$.
    
    </details>

    Code: [FindMaximumAlgorithm.cs](https://github.com/rohan-bhautoo/Algorithms/blob/main/FindMaximumAlgorithm.cs), [FindMinimumAlgorithm.cs](https://github.com/rohan-bhautoo/Algorithms/blob/main/FindMinimumAlgorithm.cs)
  
- Compute the sum or average of array elements.
  <details><summary><b>Analysis</b></summary>
    
    1. <h2>Problem Statement</h2>
    
        - Given an array of integers, compute either the sum or the average of its elements.
          
    2. <h2>Input</h2>
    
        - An array of integers of length $N$.
          
    2. <h2>Output</h2>
    
        - Sum of the elements in the array.
        - Average of the elements in the array.
          
    4. <h2>Algorithm</h2>
    
        1. The algorithm iterates through the array once, accumulating the sum of the elements. After iterating through the array, it can optionally compute the average by dividing the sum by the total number of elements.
    
    5. <h2>Time Complexity</h2>

        - The algorithm iterates through the array once, making $N$ additions for computing the sum.
        - Therefore, the time complexity for computing the sum is $O(N)$.
        - If computing the average is required, it involves one division operation, which is constant time. So, the time complexity for computing the average remains $O(N)$.

    6. <h2>Space Complexity</h2>

        - The algorithm uses only a constant amount of additional space to store variables for sum and average computation.
        - Therefore, the space complexity is $O(1)$.
    
    </details>

    Code: [SumAverageAlgorithm.cs](https://github.com/rohan-bhautoo/Algorithms/blob/main/SumAverageAlgorithm.cs)
  
- Rotate an array to the left or right.
  <details><summary><b>Analysis</b></summary>
    
    1. <h2>Problem Statement</h2>
    
        - The goal is to rotate an array to the left or right by a specified number of positions.
          
    2. <h2>Input</h2>
    
        - An array of integers of length $N$.
        - The number of positions to rotate the array.
          
    2. <h2>Output</h2>
    
        - The array after performing the rotation.
          
    4. <h2>Algorithm</h2>
    
        1. For left rotation:
            - Take the first `d` elements and move them to the end of the array.
        2. For right rotation:
            - Take the last `d` elements and move them to the beginning of the array.
      
              ```
              Lets break it down:
  
              Number of left rotation: 3
  
              First rotation:
              (1, 2, 3, 4, 5, 6, 7) → (2, 3, 4, 5, 6, 7, 1)
  
              Second rotation:
              (2, 3, 4, 5, 6, 7, 1) → (3, 4, 5, 6, 7, 1, 2)
  
              Third rotation:
              (3, 4, 5, 6, 7, 1, 2) → (4, 5, 6, 7, 1, 2, 3)
      
              ```
    
    5. <h2>Time Complexity</h2>
  
        - The time complexity for both left and right rotations is $O(N)$, where $N$ is the number of integers in the array. This is because in both cases, we need to move a certain number of integers, and the time complexity is linearly proportional to the number of integers moved.
  
    6. <h2>Space Complexity</h2>
  
        - The space complexity of the rotation algorithm is $O(1)$ because it doesn't use any additional space that scales with the size of the input. The rotations are performed in-place.
  
    7. <h2>Optimizations</h2>
  
        - If the number of positions to rotate $(d)$ is greater than the size of the array $(N)$, the modulus operation $(d mod N)$ can be used to find the effective number of positions to rotate, as rotating by $N$ positions is equivalent to not rotating at all.
        - The rotation algorithm can be optimized by reversing the entire array and then reversing the first and last portions separately. This approach will simplify the logic and can be more efficient.
    
    </details>
  
    Code: [ArrayRotationAlgorithm.cs](https://github.com/rohan-bhautoo/Algorithms/blob/main/ArrayRotationAlgorithm.cs)
  
- Searching arrays.
    - Linear Search Algorithm
      <details><summary><b>Analysis</b></summary>
    
        1. <h2>Problem Statement</h2>
        
            - Given an array of elements and a target value, determine if the target value is present in the array.
              
        2. <h2>Input</h2>
        
            - An array of integers of length $N$.
            - The target value to search for.
              
        2. <h2>Output</h2>
        
            - Index of the target value if found, otherwise -1.
              
        4. <h2>Algorithm</h2>
        
            1. Iterate through the array sequentially and compare each element with the target value until a match is found or the end of the array is reached.
        
        5. <h2>Time Complexity</h2>
    
            - In the worst-case scenario, the target value may be the last element of the array or not present at all, requiring $N$ comparisons.
            - Therefore, the time complexity for linear search is $O(N)$.
    
        6. <h2>Space Complexity</h2>
    
            - Linear search uses only a constant amount of additional space.
            - Therefore, the space complexity is $O(1)$.
    
        </details>
    
        Code: [LinearSearchAlgorithm.cs](https://github.com/rohan-bhautoo/Algorithms/blob/main/LinearSearchAlgorithm.cs)
 
    - Binary Search Algorithm
      <details><summary><b>Analysis</b></summary>
    
        1. <h2>Problem Statement</h2>
        
            - Given a sorted array of elements and a target value, determine if the target value is present in the array.
              
        2. <h2>Input</h2>
        
            - A sorted integer array of length $N$.
            - A target value to search for.
              
        2. <h2>Output</h2>
        
            - Index of the target value if found, otherwise -1.
              
        4. <h2>Algorithm</h2>
        
            1. Compare the target value with the middle element of the array.
            2. If the target value matches the middle element, return its index.
            3. If the target value is less than the middle element, repeat the search process on the left half of the array.
            4. If the target value is greater than the middle element, repeat the search process on the right half of the array.
            5. Continue this process until the target value is found or the search space is empty.
        
        5. <h2>Time Complexity</h2>
    
            - Initial Step:
                - In each step of the binary search, the search space is halved.
            - Iterations Analysis:
                - In the first step, there is $N$ elements.
                - After the first comparison, approxiamtely $\frac{N}{2}$ elements are remaining.
                - After the second comparison, approxiamtely $\frac{N}{4}$ elements are remaining.
                - After the third comparison, approxiamtely $\frac{N}{8}$ elements are remaining.
                - ...
                - This halving process continues until we find the target element or exhaust the search space.
            - Time Complexity:
                -  The time complexity of binary search is determined by the number of comparisons required, which is approximately $log{_2}(N)$.
                -  Therefore, the time complexity is $O(log N)$.
                -  The number of comparisons scales logarithmically with the size of the input array $N$. This means that as the size of the array increases, the number of comparisons needed increases at a much slower rate.
    
        6. <h2>Space Complexity</h2>
    
            - Binary search typically uses recursion, which consumes additional space proportional to the depth of the recursion stack.
            - Therefore, the space complexity is $O(log N)$ due to the recursive calls.
        
        </details>
    
        Code: [BinarySearchAlgorithm.cs](https://github.com/rohan-bhautoo/Algorithms/blob/main/BinarySearchAlgorithm.cs)
      
- Sorting arrays.
  <details><summary><b>Analysis</b></summary>
    
    1. <h2>Problem Statement</h2>
    
        - Given an unsorted array, sort the array in ascending order.
          
    2. <h2>Input</h2>
    
        - An array of integers of length $N$.
          
    2. <h2>Output</h2>
    
        - The sorted array.
          
    4. <h2>Algorithm</h2>
    
        1. Start iterating through the array from the beginning.
        2. For each element, compare it with the next element.
        2. If the current element is greater that the next element, swap them.
        4. Continue this process until the entire array is sorted.
      
            ```
            Lets break it down:
    
            First pass:
            (5, 3, 4, 1, 2) → (3, 5, 4, 1, 2)
            (3, 5, 4, 1, 2) → (3, 4, 5, 1, 2)
            (3, 4, 5, 1, 2) → (3, 4, 1, 5, 2)
            (3, 4, 1, 5, 2) → (3, 4, 1, 2, 5)
            
            Second pass:
            (3, 4, 1, 2, 5) → (3, 4, 1, 2, 5)
            (3, 4, 1, 2, 5) → (3, 1, 4, 2, 5)
            (3, 1, 4, 2, 5) → (3, 1, 2, 4, 5)
            
            Continued passes render the list completely sorted:
            (1, 2, 3, 4, 5)
            ```
    
    5. <h2>Time Complexity</h2>

        - Outer Loop
            - The outer loop iterates over the array length $(N - 1)$ times, where $N$ is the length of the array. This loop controls the number of passes needed to sort the array.

              ```c#
              for(int i = 0; i < N - 1; i++)
              ```

        - Inner Loop
            - The inner loop also iterates over the array length, but it decreaess by one in each subsequent pass $(N - 1 - i)$, where i is the index of the outer loop. This loop performs comparisons and potential swaps.
         
              ```c#
              for(int j = 0; j < N - 1 - i; j++)
              ```
              
        - Time Complexity Calculation
            - To analyze the time complexity, we need to consider the number of comparisons and swaps performed by the algorithm.
         
                - Comparisons: In each pass of the outer loop, the inner loop performs $N - 1$ comparisons. Since the outer loop iterate $N - 1$ times, the total number of comparisons is roughly $(N - 1) * (N - 1) = N^2 - 2N + 1$ comparisons.
                - Swaps: The number of swaps can vary based on the initial ordering of the array.
                    - Worst-Case Scenario: The array is in reverse order. Bubble Sort performs a swap for almost every comparison.
                    - Best-Case Scenario: If the array is already sorted, no swaps are needed.
                - Total Time Complexity:
                    - Inner Loop Iterations:
                        -  In the first iteration of the outer loop, the inner loop performs $N - 1$ iterations.
                        -  In the second iteration of the outer loop, the inner loop performs $N - 2$ iterations.
                        -  In the third iteration of the outer loop, the inner loop performs $N - 3$ iterations.
                        -  ...
                        -  In the $(N - 1)$<sup>th</sup> iteration of the outer loop, the inner loop performs 1 iteration.
                    - Total Iterations of the Inner Loop:
                        - The total number of iterations performed by the inner loop can be calculated by summing the arithmetic sequence:
                          - $(N - 1) + (N - 2) + (N - 3) + ... + 1$
                          - This sequence can be represented as a triangular number and the sum of the first N natural numbers can be calculated using the formula:
                            $$\sum_{i=1}^N i = \frac{N(N+1)}{2}$$
                          - So, when substituting $N - 1$ for $N$ in the formula (because we're summing from 1 to N -1), the total number of iterations of the inner loop is:
                            $$\sum_{i=1}^{N-1} i = \frac{(N-1)((N-1)+1)}{2} = \frac{N^2-N}{2} = \frac{N(N-1)}{2}$$
                    - Total Comparisons:
                        - Since each iteration of the inner loop performs a comparison, the total number of comparisons is equal to the total iterations of the inner loop.
                    - Time Complexity:
                        - Since each iteration of the inner loop performs a comparison, the total number of comparisons is equal to the total iterations of the inner loop.
                    - Time Complexity:
                        - The complexity is $\frac{N^2-N}{2}$, therefore $O(N^2)$ (in Big O notation, we discard the lower-order terms and constant factors like $-\frac{N}{2}$, because the number of comparisons scales quadratically with the size of the input array $N$.

    6. <h2>Space Complexity</h2>

        - Bubble Sort is an in-place sorting algorithm, meaning it doesn't require additional space other that the input array itself. Therefore, its space complexity is $O(1)$.

    7. <h2>Optimizations</h2>

        - A flag can be introduced to check if any swaps were made in a pass. If no swaps were made, it indicates that the array is already sorted and you can terminate early.

            ```c#
            public static void BubbleSort(int[] arr) {
              int n = arr.Length;
              for (int i = 0; i < n - 1; i++) {
                  bool swapped = false;
                  for (int j = 0; j < n - 1 - i; j++) {
                      if (arr[j] > arr[j + 1]) {
                          int temp = arr[j];
                          arr[j] = arr[j + 1];
                          arr[j + 1] = temp;
                          swapped = true;
                      }
                  }
                  // If no two elements were swapped in the inner loop, then the array is already sorted
                  if (!swapped)
                      break;
                }
            }
            ```
    
    </details>

    Code: [BubbleSortAlgorithm.cs](https://github.com/rohan-bhautoo/Algorithms/blob/main/BubbleSortAlgorithm.cs)

## String Manipulation:

- Reverse a string or a sentence.
- Check if a string is a palindrome.
- Find the first non-repeated character in a string.
- Implement string matching algorithms.

## Linked Lists:

- Reverse a linked list.
- Detect a cycle in a linked list.
- Find the middle of a linked list.
- Merge two sorted linked lists.

## Trees and Graphs:

- Implement tree traversal algorithms (in-order, pre-order, post-order).
- Find the height or depth of a tree.
- Check if a binary tree is balanced.
- Implement graph traversal algorithms (DFS, BFS).

## Dynamic Programming:

- Solve problems using a bottom-up or top-down approach.
- Examples include the knapsack problem, longest common subsequence, or coin change problem.

## Search Algorithms:

- Implement binary search on a sorted array.
- Solve problems using depth-first search (DFS) or breadth-first search (BFS).

## Greedy Algorithms:

- Solve problems that involve making locally optimal choices at each stage with the hope of finding a global optimum.
- Examples include the activity selection problem or Huffman coding.

## Hashing:

- Solve problems using hash tables or hash maps.
- Examples include finding duplicates in an array or implementing an LRU (Least Recently Used) cache.

## Bit Manipulation:

- Perform bitwise operations.
- Solve problems involving bits, such as counting set bits or finding the single non-repeated element in an array.

## Sorting and Searching:

- Implement various sorting algorithms (quicksort, mergesort).
- Solve search problems efficiently using techniques like binary search.

## Divide and Conquer:

- Solve problems by breaking them into smaller sub-problems and combining their solutions.
- Examples include the binary search algorithm or the merge sort algorithm.

## Backtracking:

- Solve problems where the solution is found incrementally by trying different possibilities.
- Examples include the N-Queens problem or the Sudoku solver.
