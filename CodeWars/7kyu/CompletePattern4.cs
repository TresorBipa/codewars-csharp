﻿/*
https://www.codewars.com/kata/55736129f78b30311300010f/csharp

7 kyu
Complete The Pattern #4

Task:
You have to write a function pattern which creates the following pattern upto n number of rows. 
If the Argument is 0 or a Negative Integer then it should return "" i.e. empty string.

Examples:

pattern(4):
1234
234
34
4

pattern(6):
123456
23456
3456
456
56
6

Note: There are no blank spaces
Hint: Use \n in string to jump to next line
*/

using System.Linq;

namespace CodeWars
{
    public class CompletePattern4
    {
        public static string Pattern(int n)
        {
            return string.Join("\n",
                Enumerable.Range(0, n < 1 ? 0 : n).Select(i => string.Concat(Enumerable.Range(1, n).Skip(i))));
        }
    }
}