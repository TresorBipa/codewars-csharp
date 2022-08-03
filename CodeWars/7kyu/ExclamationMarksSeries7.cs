/*
https://www.codewars.com/kata/57fafb6d2b5314c839000195/csharp

7 kyu
Exclamation marks series #7: Remove words from the sentence if it contains one exclamation mark

Description:
Remove words from the sentence if it contains one exclamation mark. Words are separated by spaces in the sentence. Please remember, one.

Examples
remove("Hi!") === ""
remove("Hi! Hi!") === ""
remove("Hi! Hi! Hi!") === ""
remove("Hi Hi! Hi!") === "Hi"
remove("Hi! !Hi Hi!") === ""
remove("Hi! Hi!! Hi!") === "Hi!!"
remove("Hi! !Hi! Hi!") === "!Hi!"
Note
Please don't post issue about difficulty or duplicate.
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CodeWars
{
    public static class ExclamationMarksSeries7
    {
        public static string Remove(string s)
        {
            return string.Join(" ", s.Split().Where(x => x.Split("!").Length != 2));
        }
    }
}


