/*
https://www.codewars.com/kata/56c2acc8c44a3ad6e400050a/csharp

7 kyu
Monkey's MATH 01: How many "ZERO"s?

Gigi is a clever monkey, living in the zoo, his teacher (animal keeper) recently taught him some knowledge of "0".

In Gigi's eyes, "0" is a character contains some circle(maybe one, maybe two).

So, a is a "0",b is a "0",6 is also a "0"，and 8 have two "0" ,etc...

Now, write some code to count how many "0"s in the text.

Let us see who is smarter? You ? or monkey?

Input always be a string(including words numbers and symbols)，
You don't need to verify it, but pay attention to the difference between uppercase and lowercase letters.

Here is a table of characters：

one zero	abdegopq069DOPQR         () <-- A pair of braces as a zero
two zero	%&B8
Output will be a number of "0".
*/

using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class MonkeysMATH01
    {
        public static int CountZero(string s)
        {
            return s.Replace("()", "a").Sum(c => "abdegopq069DOPQR".Contains(c) ? 1 : "%&B8".Contains(c) ? 2 : 0);

            // return Regex.Matches(s, @"[abdegopq069DOPQR]|(\(\))").Count + 2 * Regex.Matches(s, "[%&B8]").Count;

            // return s.Replace("()", "a").Count(x => "abdegopq069DOPQR".Contains(x)) + s.Count(x => "%&B8".Contains(x)) * 2;

            // s = s.Replace("()", "0");
            // return s.Count(c => "abdegopq069DOPQR".Contains(c)) * 1 +
            //        s.Count(c => "%&B8".Contains(c)) * 2;
        }
    }
}