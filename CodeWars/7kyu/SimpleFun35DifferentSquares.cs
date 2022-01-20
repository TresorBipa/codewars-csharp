/*
https://www.codewars.com/kata/588805ca44c7e8c3a100013c/csharp

7 kyu
Simple Fun #35: Different Squares

Task
Given a rectangular matrix containing only digits, calculate the number of different 2 × 2 squares in it.

Example
For

matrix = [[1, 2, 1],
          [2, 2, 2],
          [2, 2, 2],
          [1, 2, 3],
          [2, 2, 1]]
the output should be 6.

Here are all 6 different 2 × 2 squares:

1 2
2 2

2 1
2 2

2 2
2 2

2 2
1 2

2 2
2 3

2 3
2 1
Input/Output
[input] 2D integer array matrix

Constraints:

1 ≤ matrix.length ≤ 100,

1 ≤ matrix[i].length ≤ 100,

0 ≤ matrix[i][j] ≤ 9.

[output] an integer

The number of different 2 × 2 squares in matrix.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class SimpleFun35DifferentSquares
    {
        public int DifferentSquares(int[][] matrix)
        {
            var squares = Enumerable.Range(1, matrix.Length - 1).SelectMany(i =>
            {
                string Selector(int j) =>
                    $"{matrix[i - 1][j - 1]},{matrix[i - 1][j]},{matrix[i][j - 1]},{matrix[i][j]}";

                return Enumerable.Range(1, matrix[i].Length - 1).Select(Selector);
            });
            return squares.Distinct().Count();


            // var squares = Enumerable.Range(1, matrix.Length - 1).SelectMany(i =>
            //     Enumerable.Range(1, matrix[i].Length - 1).Select(j =>
            //         $"{matrix[i - 1][j - 1]},{matrix[i - 1][j]},{matrix[i][j - 1]},{matrix[i][j]}"));
            // return squares.Distinct().Count();


            // HashSet<int> hashset = new HashSet<int>();
            // for (int i = 0; i < (matrix.Length - 1); i++)
            // {
            //     for (int j = 0; j < (matrix[i].Length - 1); j++)
            //     {
            //         int squareCode = matrix[i][j] + matrix[i + 1][j] * 10 +
            //                          matrix[i][j + 1] * 100 + matrix[i + 1][j + 1] * 1000;
            //         hashset.Add(squareCode);
            //     }
            // }
            // return hashset.Count;


            // List<int[]> zestaw = new List<int[]>();
            // for (int i = 0; i < matrix.Length - 1; i++)
            // {
            //     for (int j = 0; j < matrix[0].Length - 1; j++)
            //     {
            //         int[] temp = new int[4];
            //         temp[0] = matrix[i][j];
            //         temp[1] = matrix[i][j + 1];
            //         temp[2] = matrix[i + 1][j];
            //         temp[3] = matrix[i + 1][j + 1];
            //         if (zestaw.All(x => !x.SequenceEqual(temp))) zestaw.Add(temp);
            //     }
            // }
            // return zestaw.Count();


            // var unique_square_counter = new HashSet<Tuple<int, int, int, int>>();
            // for (int i = 0; i < matrix.Length - 1; i++)
            // {
            //     for (int j = 0; j < matrix[0].Length - 1; j++)
            //     {
            //         unique_square_counter.Add(new Tuple<int, int, int, int>(matrix[i][j], matrix[i][j + 1],
            //             matrix[i + 1][j], matrix[i + 1][j + 1]));
            //     }
            // }
            // return unique_square_counter.Count;
        }
    }
}