/*
https://www.codewars.com/kata/59e19a747905df23cb000024/csharp

6 kyu
String Letter Counting

Take an input string and return a string that is made up of the number of occurences of each english letter in the input followed by that letter, sorted alphabetically. 
The output string shouldn't contain chars missing from input (chars with 0 occurence); leave them out.

An empty string, or one with no letters, should return an empty string.

Notes:

the input will always be valid;
treat letters as case-insensitive
Examples
"This is a test sentence."  ==>  "1a1c4e1h2i2n4s4t"
""                          ==>  ""
"555"                       ==>  ""
*/

using System.Linq;

namespace CodeWars
{
    public class StringLetterCounting
    {
        public static string StringLetterCount(string str)
        {
            return string.Concat(str.ToLower()
                .Where(char.IsLetter)
                .OrderBy(c => c)
                .GroupBy(c => c)
                .Select(g => $"{g.Count()}{g.Key}"));
        }
    }
}