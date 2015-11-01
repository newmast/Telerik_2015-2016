## Data Structures, Algorithms and Complexity Homework

1. **What is the expected running time of the following C# code?**
  - Explain why using Markdown.
  - Assume the array's size is `n`.

  ```cs
  long Compute(int[] arr)
  {
      long count = 0;
      for (int i=0; i<arr.Length; i++)
      {
          int start = 0, end = arr.Length-1;
          while (start < end)
              if (arr[start] < arr[end])
                  { start++; count++; }
              else 
                  end--;
      }
      return count;
  }
  ```
  **Answer**
  The first for loop is going to run a total ot n times. 
  Afterwards the while loop is going to run for another n/2 times due to the indexes in/decreasing with each iteration. 
  Therefore the complexity of the algorithm would be most accurately represented as O(n^2/2).
  
2. **What is the expected running time of the following C# code?**
  - Explain why using Markdown.
  - Assume the input matrix has size of `n * m`.

  ```cs
  long CalcCount(int[,] matrix)
  {
      long count = 0;
      for (int row=0; row<matrix.GetLength(0); row++)
          if (matrix[row, 0] % 2 == 0)
              for (int col=0; col<matrix.GetLength(1); col++)
                  if (matrix[row,col] > 0)
                      count++;
      return count;
  }
  ```
  **Answer**
  The first for loop will iterate n times regardless of the situation.
  The second loop will only run if a number is countable, so:
  - Worst-case: Every time or a total of m times;
  - Best-case: Never;
  To conclude, the worst-case complexity is O(n*m) and the best-case one is linear -> O(n).
  
3. **(*) What is the expected running time of the following C# code?**
  - Explain why using Markdown.
  - Assume the input matrix has size of `n * m`.

  ```cs
  long CalcSum(int[,] matrix, int row)
  {
      long sum = 0;
      for (int col = 0; col < matrix.GetLength(0); col++) 
          sum += matrix[row, col];
      if (row + 1 < matrix.GetLength(1)) 
          sum += CalcSum(matrix, row + 1);
      return sum;
  }
  
  Console.WriteLine(CalcSum(matrix, 0));
  ```
  **Answer**
  The for loop and the recursion act together and simulate a two nested for loops. Which means:
  - Worst-case: row parameter is zero from the start the the algorithm runs O(n^2) times.
  - Best-case: row parameter is equal to the matrix length - 1 and the algorithm runs O(n) times.