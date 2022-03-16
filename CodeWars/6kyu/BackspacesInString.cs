/*
https://www.codewars.com/kata/5727bb0fe81185ae62000ae3/csharp

6 kyu
Backspaces in string

Assume "#" is like a backspace in string. This means that string "a#bc#d" actually is "bd"

Your task is to process a string with "#" symbols.

Examples
"abc#d##c"      ==>  "ac"
"abc##d######"  ==>  ""
"#######"       ==>  ""
""              ==>  ""
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class BackspacesInString
    {
        public static string CleanString(string s)
        {
            // return Regex.Replace(s, "((?<c>[^#])|(?<-c>#))*(?(c)(?!))#*", "");
            // return s.Aggregate("", (a, c) => c == '#' ? a.Any() ? a[..^1] : a : a + c);
            // return s.Aggregate("", (a, c) => c == '#' && a.Any() ? a[..^1] : $"{a}{c}");
            // return s.Aggregate("", (r, c) => c == '#' ? r[..Math.Max(r.Length - 1, 0)] : r + c);
            // return s.Aggregate("", (a, c) => c == '#' ? string.Concat(a.Take(a.Length - 1)) : a + c);
            // return s.Aggregate("", (a, c) => c == '#' ? a.Any() ? a.Remove(a.Length - 1, 1) : a : a + c);

            // return s.Contains('#')
            //     ? s.IndexOf('#') == 0 ? CleanString(s.Remove(0, 1)) : CleanString(s.Remove(s.IndexOf('#') - 1, 2))
            //     : s;


            while (s.Length != (s = Regex.Replace(s, "[^#]#", "")).Length)
            {
            }

            return s.Replace("#", "");
        }
    }
}