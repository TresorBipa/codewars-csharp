/*
https://www.codewars.com/kata/5168bb5dfe9a00b126000018/csharp

8 kyu
Reversed Strings

Complete the solution so that it reverses the string passed into it.
'world'  =>  'dlrow'
*/

using System.Linq;

namespace CodeWars
{
    public static class ReversedStrings
    {
        public static string Solution(string str)
        {
            // return new string(str.Reverse().ToArray());
            return string.Concat(str.Reverse());
        }
    }
}