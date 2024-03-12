# Data Structures

## Arrays
Arrays are used to store a list of items. Looking for item based on the index is super fast.

```c#
int[] numbers = { 10, 20, 30 };
```

- Lookup
  - Time complexity: $O(1)$
- Insert
  - Time complexity: $O(N)$
- Delete
  - Time complexity:
    - Best case: Removing last item of the array
      - $O(1)$
    - Worst case: Removing an item from the beginning of the array. All items of the array need to shift to fill up the hole.
      - $O(N)$

### Limitation
Arrays are static which means that the size of the array is fixed and cannot be changed overtime.

## Linked Lists
Linked Lists are used to store a list of object in sequence. Unlike arrays, linked list can grow or shrink automatically.

A linked list consists of a group of node in sequence. Each node holds 2 pieces of data (value & next - which references the next node). These nodes are linked together. The first node is referred to as the `Head` and the last node as the `Tail`.

![Linked-List-Data-Structure](https://github.com/rohan-bhautoo/Data-Structures-and-Algorithms/assets/47154593/d4539063-5139-43c6-9bef-15d2f99d4683)

- Lookup
  - By value:
    - Time complexity: $O(N)$
  - By index:
    - Time complexity: $O(N)$
- Insert
  - At the end:
    - Time complexity: $O(1)$
  - At the beginning:
    - Time complexity: $O(1)$
  - In the middle:
    - Time complexity: $O(N)$
- Delete
  - At the end:
    - Time complexity: $O(N)$
  - At the beginning:
    - Time complexity: $O(1)$
  - In the middle:
    - Time complexity: $O(N)$

## Stacks


## Queues


## Hash Tables
