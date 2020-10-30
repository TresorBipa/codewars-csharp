/*
https://www.codewars.com/kata/57ed56657b45ef922300002b/csharp

7 kyu
The Office III - Broken Photocopier

The bloody photocopier is broken... Just as you were sneaking around the office to print off your favourite binary code!

Instead of copying the original, it reverses it: '1' becomes '0' and vice versa.

Given a string of binary, return the version the photocopier gives you as a string.

The Office I - Outed
The Office II - Boredeom Score
The Office IV - Find a Meeting Room
The Office V - Find a Chair
*/

using System.Linq;

namespace CodeWars
{
    public class OfficeIIIBrokenPhotocopier
    {
        public static string Broken(string x)
        {
            return x.Aggregate("", (s, c) => s + (c == '0' ? '1' : '0'));
            // return string.Concat(x.Select(a => 1 - (a - '0')));
            // return string.Concat(x.Select(a => a == '0' ? '1' : '0'));
            // return x.Replace('1', '*').Replace('0', '1').Replace('*', '0');
            // return new string(x.Select(e => e == '1' ? '0' : '1').ToArray());
        }
    }
}