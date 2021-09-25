/*
https://www.codewars.com/kata/string-repeat/csharp
https://www.codewars.com/kata/57a0e5c372292dd76d000d7e/csharp

8 kyu
String repeat

Write a function called repeatStr which repeats the given string string exactly n times.

repeatStr(6, "I") // "IIIIII"
repeatStr(5, "Hello") // "HelloHelloHelloHelloHello"
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CodeWars
{
    public class StringRepeat
    {
        public static string repeatStr(int n, string s)
        {
            return string.Concat(Enumerable.Repeat(s, n));
        }

        //Best Practices
        //public static string repeatStr(int n, string s)
        //{
        //    return String.Concat(Enumerable.Repeat(s, n));
        //}


        //public static string repeatStr(int n, string s)
        //{
        //    return new StringBuilder(s.Length * n).Insert(0, s, n).ToString();
        //}


        //public static string repeatStr(int n, string s)
        //{
        //    StringBuilder builder = new StringBuilder();
        //    for (int i = 0; i < n; i++)
        //    {
        //        builder.Append(s);
        //    }
        //    return builder.ToString();
        //}


        //public static string repeatStr(int n, string s)
        //{
        //    var res = "";
        //    for (int i = 0; i < n; i++)
        //    {
        //        res += s;
        //    }
        //    return res;
        //}

        //public static string repeatStr(int n, string s)
        //{
        //    return string.Join("", Enumerable.Repeat(s, n));
        //}


        //public static string repeatStr(int n, string s)
        //{
        //    string t = "";

        //    for (int i = 0; i < n; i++)
        //    {
        //        t = s + t;
        //    }
        //    return t;
        //}


        //public static string repeatStr(int n, string s)
        //{
        //    return new string(s[0], n).Replace(s[0] + "", s);
        //}


        //public static string repeatStr(int n, string s)
        //{
        //    if (n == 1) return s;
        //    return repeatStr(n - 1, s) + s;
        //}


        //public static string repeatStr(int n, string s)
        //{
        //    return string.Join(s, new string[n + 1]);
        //}
    }
}