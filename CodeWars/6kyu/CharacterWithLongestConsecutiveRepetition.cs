/*
https://www.codewars.com/kata/586d6cefbcc21eed7a001155/csharp

6 kyu
Character with longest consecutive repetition

For a given string s find the character c (or C) with longest consecutive repetition and return:

Tuple<char?, int>(c, l)
where l (or L) is the length of the repetition. 
If there are two or more characters with the same l return the first in order of appearance.

For empty string return:

Tuple<char?, int>(null, 0)
Happy coding! :)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class CharacterWithLongestConsecutiveRepetition
    {
        public static Tuple<char?, int> LongestRepetition(string input)
        {
            return input.Select((x, i) => new Tuple<char?, int>(x, input[i..].TakeWhile(c => c == x).Count()))
                       .OrderBy(x => -x.Item2).FirstOrDefault()
                   ?? new Tuple<char?, int>(null, 0);


            // return input
            //     .Aggregate(" ", (c, f) => c + (c.Last() == f ? "" : " ") + f)
            //     .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
            //     .OrderByDescending(x => x.Length)
            //     .Select(x => new Tuple<char?, int>(x.First(), x.Length))
            //     .FirstOrDefault() ?? new Tuple<char?, int>(null, 0);
        }
    }
}