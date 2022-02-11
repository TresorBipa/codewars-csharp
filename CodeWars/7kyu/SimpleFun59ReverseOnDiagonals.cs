/*
https://www.codewars.com/kata/5889a6b653ad4a22710000d0/csharp

7 kyu
Simple Fun #59: Reverse On Diagonals

Task
Given a square matrix, your task is to reverse the order of elements on both of its longest diagonals.

The longest diagonals of a square matrix are defined as follows:

the first longest diagonal goes from the top left corner to the bottom right one;
the second longest diagonal goes from the top right corner to the bottom left one.
Example
For the matrix

1, 2, 3
4, 5, 6
7, 8, 9
the output should be:

9, 2, 7
4, 5, 6
3, 8, 1
Input/Output
[input] 2D integer array matrix

Constraints: 1 ≤ matrix.length ≤ 10, matrix.length = matrix[i].length, 1 ≤ matrix[i][j] ≤ 1000

[output] 2D integer array

Matrix with the order of elements on its longest diagonals reversed.
*/

namespace CodeWars
{
    public class SimpleFun59ReverseOnDiagonals
    {
        public int[][] ReverseOnDiagonals(int[][] matrix)
        {
            int n = matrix.Length;
            for (int i = 0; i < n / 2; i++)
            {
                int j = n - 1 - i;

                int temp = matrix[j][j];
                matrix[j][j] = matrix[i][i];
                matrix[i][i] = temp;

                temp = matrix[j][i];
                matrix[j][i] = matrix[i][j];
                matrix[i][j] = temp;
            }

            return matrix;


            // for (int x = 0, y = matrix.Length - 1; x < y; ++x, --y)
            // {
            //     (matrix[x][x], matrix[y][y]) = (matrix[y][y], matrix[x][x]);
            //     (matrix[x][y], matrix[y][x]) = (matrix[y][x], matrix[x][y]);
            // }
            //
            // return matrix;
        }
    }
}