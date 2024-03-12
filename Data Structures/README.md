# Data Structures

## Arrays
Arrays are used to store a list of items. Looking for item based on the index is super fast.

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
