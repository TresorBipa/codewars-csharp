/*
https://www.codewars.com/kata/58ad29bc4b852b14a4000050/csharp

7 kyu
Simple Fun #157: Counting Triangles

Task
Given some sticks by an array V of positive integers, where V[i] represents the length of the sticks, 
find the number of ways we can choose three of them to form a triangle.

Example
For V = [2, 3, 7, 4], the result should be 1.

There is only (2, 3, 4) can form a triangle.

For V = [5, 6, 7, 8], the result should be 4.

(5, 6, 7), (5, 6, 8), (5, 7, 8), (6, 7, 8)

Input/Output
[input] integer array V

stick lengths

3 <= V.length <= 100

0 < V[i] <=100

[output] an integer

number of ways we can choose 3 sticks to form a triangle.
*/

using System.Linq;

namespace CodeWars
{
    public class SimpleFun157CountingTriangles
    {
        public int CountingTriangles(int[] V)
        {
            var result = 0;
            for (var i = 0; i < V.Length - 2; i++)
            {
                for (var j = i + 1; j < V.Length - 1; j++)
                {
                    for (var k = j + 1; k < V.Length; k++)
                    {
                        if (V[i] < V[j] + V[k] && V[j] < V[i] + V[k] && V[k] < V[i] + V[j]) result++;
                    }
                }
            }

            return result;
        }
    }
}