/*
https://www.codewars.com/kata/5596f6e9529e9ab6fb000014/csharp

6 kyu
Calculate String Rotation

Write a function that receives two strings and returns n, 
where n is equal to the number of characters we should shift the first string forward to match the second. 
The check should be case sensitive.

For instance, take the strings "fatigue" and "tiguefa". 
In this case, the first string has been rotated 5 characters forward to produce the second string, so 5 would be returned.

If the second string isn't a valid rotation of the first string, the method returns -1.
Examples:
"coffee", "eecoff" => 2
"eecoff", "coffee" => 4
"moose", "Moose" => -1
"isn't", "'tisn" => 2
"Esham", "Esham" => 0
"dog", "god" => -1
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CodeWars
{
    public class CalculateStringRotation
    {
        public static int ShiftedDiff(string first, string second)
        {
            // return second.Length != first.Length ? -1 : (second + second).IndexOf(first);
            return second.Length == first.Length ? (second + second).IndexOf(first) : -1;

            // return Enumerable.Range(0, second.Length).Where(i => first == second[i..second.Length] + second[..i])
            //     .DefaultIfEmpty(-1).First();


            // for (int i = 0; i < second.Length; i++)
            // {
            //     if (first == second[i..second.Length] + second[..i]) return i;
            // }
            // return -1;
        }
    }
}