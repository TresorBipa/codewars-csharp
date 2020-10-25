/*
https://www.codewars.com/kata/556cebcf7c58da564a000045/csharp

7 kyu
Number of Rectangles in a Grid

Given a grid of size m x n, calculate the total number of rectangles contained in this rectangle. 
All integer sizes and positions are counted.

Examples:

numberOfRectangles(3, 2) == 18
numberOfRectangles(4, 4) == 100
Here is how the 3x2 grid works (Thanks to GiacomoSorbi for the idea):

1 rectangle of size 3x2:

[][][]
[][][]
2 rectangles of size 3x1:

[][][]
4 rectangles of size 2x1:

[][]
2 rectangles of size 2x2

[][]
[][]
3 rectangles of size 1x2:

[]
[]
6 rectangles of size 1x1:

[]
As you can see (1 + 2 + 4 + 2 + 3 + 6) = 18, and is the solution for the 3x2 grid.

There is a very simple solution to this!
*/

using System.Linq;

namespace CodeWars
{
    public class NumberOfRectanglesInGrid
    {
        public static int NumberOfRectangles(int m, int n)
        {
            return m * n * ++m * ++n / 4;

            //return m * n * (n + 1) * (m + 1) / 4;
            //return m * (m + 1) * n * (n + 1) / 4;
            //return (m * m + m) * (n * n + n) / 4;
            //return Enumerable.Range(1, m).Sum(x => x * n * (n + 1) / 2);
            //return Enumerable.Range(1, m).SelectMany(x => Enumerable.Range(1, n).Select(y => x * y)).Sum();
        }
    }
}