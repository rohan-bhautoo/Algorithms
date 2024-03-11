# Data Structures and Algorithms
Data Structures is about how data can be stored in different structures. Algorithms is about how to solve different problems, often by searching through and manipulating data structures. Theory about Data Structures and Algorithms (DSA) helps us to use large amounts of data to solve problems efficiently.

## The Big O Notation
Big O notation is a mathematical notation that describes the limiting behavior of a function when the argument tends towards a particular value or infinity.

> [!TIP]
> Big O is used to describe the performance of an algorithm.

![1 FkQzWqqIMlAHZ_xNrEPKeA](https://github.com/rohan-bhautoo/Algorithms/assets/47154593/5ac2c1a4-1038-48df-9877-f7fc7c7e7592)

### $O(1)$
The code below prints the first item of the array. The size of the array doesn't matter. The operation takes a constant amount to run.
```c#
public void log(int[] numbers)
{
  Console.WriteLine(numbers[0])
}
```

### $O(N)$
The code below iterates over the array and prints each item in the console. The size of the input matters. The cost of this algorithm grows linearly and in direct correlation to the size of the input ($N$).
```c#
public void log(int[] numbers)
{
  for(int i = 0; i < numbers.Length; i++)
  {
    Console.WriteLine(numbers[i]);
  }
}
```

### $O(N^2)$
The code below contains a nested loop. The array is iterated twice. This algorithm runs in quadratic time, therefore as the input size grows, the algorithm runs slower.
```c#
public void log(int[] numbers)
{
  for(int i = 0; i < numbers.Length; i++)
  {
    for(int j = 0; j < numbers.Length; j++)
    {
      Console.WriteLine(numbers[j]);
    }
  }
}
```

### $O(log N)$
An algorithm that runs at logarithmic time ($O(log N)$) is more efficient and scalable than linear ($O(N)$) or ($O(N^2)$) algorithms.

For example, a linear search needs to iterate over each item of the array. In the worst case scenario, the item is at the last position of the array. However, binary search algorithm is much faster as it starts by looking at the middle item if it is greater or smaller than the searched value. This means that the array is narrowed down by half.

### $O(2^N)$

## Arrays

## Linked Lists

## Stacks

## Queues

## Hash Tables
