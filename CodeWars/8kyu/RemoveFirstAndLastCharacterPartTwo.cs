/*
https://www.codewars.com/kata/570597e258b58f6edc00230d/csharp

8 kyu
Remove First and Last Character Part Two

This is a spin off of my first kata.

You are given a string containing a sequence of characters separated by commas.

Write a function which returns another string containing all the character sequences except the first and the last ones, separated by spaces.

If the input string is empty, or the removal of the first and last items would cause the string to be empty, returns null.

Examples
// should remove the first and last character
array('1,2,3') // => '2'
array('1,2,3,4') // => '2 3'
array('1,2,3,4,5') // => '2 3 4'

// Should return null if the final string is empty
array('') // => '' => null
array('1') // => '' => null
array('1,2') // => '' => null
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace CodeWars
{
    public static class RemoveFirstAndLastCharacterPartTwo
    {
        public static string Array(string s)
        {
            var arr = s.Split(",");
            return arr.Length > 2 ? string.Join(" ", arr[1..^1]) : null;


            // var arr = s.Split(",").ToList();
            // if (arr.Count > 1)
            // {
            //     arr.RemoveAt(0);
            //     arr.RemoveAt(arr.Count - 1);
            // }
            //
            //
            // return s.Split(",").Length > 2 ? string.Join(" ", arr) : null;
        }
    }
}