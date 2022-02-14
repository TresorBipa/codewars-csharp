/*
https://www.codewars.com/kata/5889ab4928c08c08da00009b/csharp

7 kyu
Simple Fun #61: Crossing Sum

Task
Given a rectangular matrix and integers a and b, consider the union of the ath row and the bth (both 0-based) column of the matrix. 
Return sum of all elements of that union.

Example
For

matrix = [[1, 1, 1, 1], [2, 2, 2, 2], [3, 3, 3, 3]] a = 1 and b = 3 the output should be 12.

Here (2 + 2 + 2 + 2) + (1 + 3) = 12.

Input/Output
[input] 2D integer array matrix

2-dimensional array of integers representing a rectangular matrix.

Constraints: 1 ≤ matrix.length ≤ 5, 1 ≤ matrix[0].length ≤ 5, 1 ≤ matrix[i][j] ≤ 100.

[input] integer a

A non-negative integer less than the number of matrix rows.

Constraints: 0 ≤ a < matrix.length.

[input] integer b

A non-negative integer less than the number of matrix columns.

Constraints: 0 ≤ b < matrix[i].length.

[output] an integer
*/

using System.Linq;

namespace CodeWars
{
    public class SimpleFun61CrossingSum
    {
        public int CrossingSum(int[][] matrix, int a, int b)
        {
            return matrix[a].Sum() + matrix.Sum(x => x[b]) - matrix[a][b];
            //return matrix[a].Sum() + matrix.Select(row => row[b]).Sum() - matrix[a][b];
            //return matrix[a].Sum() + matrix.Select((x, i) => i == a ? 0 : x[b]).Sum();
            //return matrix[a].Sum() + matrix.Select(x => x[b]).Sum() - matrix[a][b];

            // int crossSum = 0, i = 0;
            // foreach (var row in matrix)
            // {
            //     if (i == a) crossSum += row.Sum();
            //     else crossSum += row[b];
            //     i++;
            // }
            // return crossSum;
        }
    }
}