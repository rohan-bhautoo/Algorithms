# Data Structures and Algorithms

## The Big O Notation
Big O notation is a mathematical notation that describes the limiting behavior of a function when the argument tends towards a particular value or infinity.

> [!TIP]
> Big O is used to describe the performance of an algorithm.

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
```c#
public void log(int[] numbers)
{
  for(int i = 0; i < numbers.Length; i++)
  {
    Console.WriteLine(numbers[i]);
  }
}
```

### $O(log N)$

### $O(2^N)$

## Arrays

## Linked Lists

## Stacks

## Queues

## Hash Tables
