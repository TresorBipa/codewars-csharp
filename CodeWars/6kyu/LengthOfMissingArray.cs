/*
https://www.codewars.com/kata/57b6f5aadb5b3d0ae3000611/train/csharp

6 kyu
Length of missing array

You get an array of arrays.
If you sort the arrays by their length, you will see, that their length-values are consecutive.
But one array is missing!

You have to write a method, that return the length of the missing array.

Example:
[[1, 2], [4, 5, 1, 1], [1], [5, 6, 7, 8, 9]] --> 3

If the array of arrays is null/nil or empty, the method should return 0.

When an array in the array is null or empty, the method should return 0 too!
There will always be a missing element and its length will be always between the given arrays.

Have fun coding it and please don't forget to vote and rank this kata! :-)

I have created other katas. Have a look if you like coding and challenges.
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class LengthOfMissingArray
    {
        public static int GetLengthOfMissingArray(object[][] arr)
        {
            return arr == null || arr.Length == 0 || arr.Any(x => x == null || x.Length == 0)
                ? 0
                : Enumerable.Range(arr.Min(x => x.Length), arr.Length).Except(arr.Select(x => x.Length)).First();
        }
    }
}