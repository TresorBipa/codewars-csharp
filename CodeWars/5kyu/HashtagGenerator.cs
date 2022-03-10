/*
https://www.codewars.com/kata/52449b062fb80683ec000024/csharp

5 kyu
The Hashtag Generator

The marketing team is spending way too much time typing in hashtags.
Let's help them with our own Hashtag Generator!

Here's the deal:

It must start with a hashtag (#).
All words must have their first letter capitalized.
If the final result is longer than 140 chars it must return false.
If the input or the result is an empty string it must return false.
Examples
" Hello there thanks for trying my Kata"  =>  "#HelloThereThanksForTryingMyKata"
"    Hello     World   "                  =>  "#HelloWorld"
""                                        =>  false
*/

using System.Globalization;

namespace CodeWars
{
    public static class HashtagGenerator
    {
        public static string GenerateHashtag(string s)
        {
            var result = "#" + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(s.ToLower()).Replace(" ", "");
            return result.Length < 2 || result.Length > 140 ? null : result;

            // var result = string.Concat(("# " + s).ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries)
            //     .Select(x => char.ToUpper(x[0]) + x[1..]));
            // return result.Length < 2 || result.Length > 140 ? null : result;
        }
    }
}