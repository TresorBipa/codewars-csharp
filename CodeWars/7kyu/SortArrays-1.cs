/*
https://www.codewars.com/kata/51f41b98e8f176e70d0002a8/csharp

7 kyu
Sort arrays - 1

Just a simple sorting usage. Create a function that returns the elements of the input-array in a sorted manner.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class SortArrays_1
    {
        public static string[] SortMe(string[] names)
        {
            // Array.Sort(names);
            // return names;

            return names.OrderBy(s => s).ToArray();
        }
    }
}