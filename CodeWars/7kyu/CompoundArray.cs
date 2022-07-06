/*
https://www.codewars.com/kata/56044de2aa75e28875000017/csharp

7 kyu
CompoundArray

You have to create a method "compoundArray" which should take as input two int arrays of different length and return one int array with numbers of both arrays shuffled one by one.

Input - {1,2,3,4,5,6} and {9,8,7,6} 
Output - {1,9,2,8,3,7,4,6,5,6}
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class KataCompoundArray
    {
        public static int[] CompoundArray(int[] a, int[] b)
        {
            return Enumerable.Range(0, Math.Max(a.Length, b.Length))
                .SelectMany((_, i) => a.Skip(i).Take(1).Concat(b.Skip(i).Take(1)))
                .ToArray();
        }
    }
}