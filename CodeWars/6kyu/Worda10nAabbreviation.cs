/*
https://www.codewars.com/kata/5375f921003bf62192000746/csharp

6 kyu
Word a10n (abbreviation)

The word i18n is a common abbreviation of internationalization in the developer community, 
used instead of typing the whole word and trying to spell it correctly. 
Similarly, a11y is an abbreviation of accessibility.

Write a function that takes a string and turns any and all "words" (see below) within that string of length 4 or greater into an abbreviation, following these rules:

A "word" is a sequence of alphabetical characters. 
By this definition, any other character like a space or hyphen (eg. "elephant-ride") will split up a series of letters into two words (eg. "elephant" and "ride").

The abbreviated version of the word should have the first letter, 
then the number of removed characters, then the last letter (eg. "elephant ride" => "e6t r2e").

Example
abbreviate("elephant-rides are really fun!")
//          ^^^^^^^^*^^^^^*^^^*^^^^^^*^^^*
// words (^):   "elephant" "rides" "are" "really" "fun"
//                123456     123     1     1234     1
// ignore short words:               X              X

// abbreviate:    "e6t"     "r3s"  "are"  "r4y"   "fun"
// all non-word characters (*) remain in place
//                     "-"      " "    " "     " "     "!"
=== "e6t-r3s are r4y fun!"
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CodeWars
{
    public class Worda10nAabbreviation
    {
        public static string Abbreviate(string input)
        {
            return Regex.Replace(input, @"\B\w{2,}\B", m => m.Length.ToString());
            // return Regex.Replace(input, @"\B\w{2,}\B", t => t.Length + "");
            // return Regex.Replace(input, @"\B\w{2,}\B", m => $"{m.Length}");
            // return Regex.Replace(input, @"\w{4,}", m => string.Concat(m.ToString().First(), m.ToString().Length - 2, m.ToString().Last()));
            // return Regex.Replace(input, "\\w{4,}", m => $"{m.Value[0]}{m.Value.Length - 2}{m.Value[^1]}");
            // return string.Concat(Regex.Split(input, "([^a-zA-Z])").Select(x => x.Length >= 4 ? $"{x[0]}{x.Length - 2}{x.Last()}" : x));
            // return Regex.Replace(input, @"\b\w{4,}\b", x => $"{x.Value[0]}{x.Length - 2}{x.Value[x.Length - 1]}");


            // var separators = new[] { ' ', '\'', '.', ',', '-', ';', ':' };
            // var words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            // return words.Where(x => x.Length > 3).Aggregate(input,
            //     (s, w) => s.Replace(w, $"{w[0]}{w.Length - 2}{w[^1]}"));
        }
    }
}