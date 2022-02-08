/*
https://www.codewars.com/kata/588856a82ffea640c80000cc/csharp

7 kyu
Simple Fun #51: Array Previous Less

Task
Given array of integers, for each position i, search among the previous positions for the last (from the left) position that contains a smaller value. 
Store this value at position i in the answer. If no such value can be found, store -1 instead.

Example
For items = [3, 5, 2, 4, 5], the output should be [-1, 3, -1, 2, 4].

Input/Output
[input] integer array arr

Non-empty array of positive integers.

Constraints: 3 ≤ arr.length ≤ 1000, 1 ≤ arr[i] ≤ 1000.

[output] an integer array

Array containing answer values computed as described above.
*/

using System.Linq;

namespace CodeWars
{
    public class SimpleFun51ArrayPreviousLess
    {
        public int[] ArrayPreviousLess(int[] arr)
        {
            return arr.Select((x, i) => arr.Take(i).Where(n => n < x).DefaultIfEmpty(-1).Last()).ToArray();

            // return arr.Select((el, i) =>
            //     arr.Take(i)
            //         .Where(x => x < el)
            //         .DefaultIfEmpty(-1)
            //         .Last()
            // ).ToArray();

            // return arr.Select((x, i) => arr.Take(i).Any(k => k < x) ? arr.Take(i).Reverse().First(y => y < x) : -1)
            //     .ToArray();
        }
    }
}