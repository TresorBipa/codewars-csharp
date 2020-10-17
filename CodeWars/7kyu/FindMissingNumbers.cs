/*
https://www.codewars.com/kata/56d02e6cc6c8b49c510005bb/csharp

7 kyu
Find missing numbers

You will get an array of numbers.

Every preceding number is smaller than the one following it.

Some numbers will be missing, for instance:
[-3,-2,1,5] //missing numbers are: -1,0,2,3,4

Your task is to return an array of those missing numbers:
[-1,0,2,3,4]
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class KataFindMissingNumbers
    {
        public static int[] FindMissingNumbers(int[] arr)
        {
            return arr.Any() ? Enumerable.Range(arr[0], arr[^1] - arr[0]).Except(arr).ToArray() : new int[0];
            // return arr.Any() ? Enumerable.Range(arr[0], arr[^1] - arr[0]).Except(arr).ToArray() : Array.Empty<int>();
        }
    }
}