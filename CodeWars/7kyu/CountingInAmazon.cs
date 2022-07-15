/*
https://www.codewars.com/kata/55b95c76e08bd5eef100001e/csharp

7 kyu
Counting in the Amazon

The Arara are an isolated tribe found in the Amazon who count in pairs. For example one to eight is as follows:

1 = anane
2 = adak
3 = adak anane
4 = adak adak
5 = adak adak anane
6 = adak adak adak
7 = adak adak adak anane
8 = adak adak adak adak

Take a given number and return the Arara's equivalent.

e.g.

Kata.CountArara(3) // "adak anane"

Kata.CountArara(8) // "adak adak adak adak"
https://en.wikipedia.org/wiki/Arara_people
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class CountingInAmazon
    {
        public static string CountArara(int n)
        {
            return string.Concat(Enumerable.Repeat("adak ", (n - 1) / 2)) + (n % 2 == 1 ? "anane" : "adak");
            // return string.Join(" ", Enumerable.Repeat("adak", n / 2).Concat(Enumerable.Repeat("anane", n % 2)));
        }
    }
}