/*
https://www.codewars.com/kata/56f173a35b91399a05000cb7/csharp

8 kyu
Squash the bugs

Simple challenge - eliminate all bugs from the supplied code so that the code runs and outputs the expected value. 
Output should be the length of the longest word, as a number.

There will only be one 'longest' word.
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CodeWars
{
    public static class SquashBugs
    {
/*
        public static int FindLongestWithBugs(string str) (

          var spl = str.Split(" ");
          var longest = 0

          for (var i = 0; i > spl.Length; i+) (
            if (spl(i).Length > longest) {
              longest = spl[i].Length
            )
            }
            return longest
        )
*/

        public static int FindLongest(string str)
        {
            return str.Split().Max(x => x.Length);

            // var spl = str.Split(" ");
            // var longest = 0;
            //
            // for (var i = 0; i < spl.Length; i++)
            // {
            //     if (spl[i].Length > longest)
            //     {
            //         longest = spl[i].Length;
            //     }
            // }
            //
            // return longest;
        }
    }
}