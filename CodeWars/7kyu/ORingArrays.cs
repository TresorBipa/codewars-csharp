/*
https://www.codewars.com/kata/5ac5e9aa3853da25d9000102/csharp

7 kyu
ORing arrays

It started as a discussion with a friend, who didn't fully grasp some way of setting defaults, 
but I thought the idea was cool enough for a beginner kata: 
binary OR each matching element of two given arrays (or lists, if you do it in Python; vectors in c++) 
of integers and give the resulting ORed array [starts to sound like a tonguetwister, doesn't it?].

If one array is shorter than the other, use the optional third parameter (defaulted to 0) to OR the unmatched elements.

For example:

orArrays([1,2,3],[1,2,3]) === [1,2,3]
orArrays([1,2,3],[4,5,6]) === [5,7,7]
orArrays([1,2,3],[1,2]) === [1,2,3]
orArrays([1,2],[1,2,3]) === [1,2,3]
orArrays([1,2,3],[1,2,3],3) === [1,2,3]
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class ORingArrays
    {
        public static int[] OrArrays(int[] arr1, int[] arr2, int d = 0)
        {
            return new int[Math.Max(arr1.Length, arr2.Length)]
                .Select((_, i) => (arr1.Length > i ? arr1[i] : d) | (arr2.Length > i ? arr2[i] : d)).ToArray();

            // return Enumerable.Range(0, Math.Max(arr1.Length, arr2.Length))
            //     .Select(x => (arr1.Length > x ? arr1[x] : d) | (arr2.Length > x ? arr2[x] : d)).ToArray();

            // return arr1.Zip(arr2, (x, y) => x | y)
            //     .Concat(arr1.Skip(arr2.Length).Select(x => x | d))
            //     .Concat(arr2.Skip(arr1.Length).Select(x => x | d))
            //     .ToArray();
        }
    }
}