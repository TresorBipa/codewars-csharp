/*
https://www.codewars.com/kata/52b757663a95b11b3d00062d/csharp

6 kyu
WeIrD StRiNg CaSe

Write a function toWeirdCase (weirdcase in Ruby) that accepts a string, 
and returns the same string with all even indexed characters in each word upper cased, and all odd indexed characters in each word lower cased. 
The indexing just explained is zero based, so the zero-ith index is even, therefore that character should be upper cased.

The passed in string will only consist of alphabetical characters and spaces(' '). 
Spaces will only be present if there are multiple words. Words will be separated by a single space(' ').

Examples:
toWeirdCase( "String" );//=> returns "StRiNg"
toWeirdCase( "Weird string case" );//=> returns "WeIrD StRiNg CaSe"
*/

using System.Linq;

namespace CodeWars
{
    public class WeIrDStRiNgCaSe
    {
        public static string ToWeirdCase(string s)
        {
            return string.Join(" ",
                s.Split().Select(x =>
                    string.Concat(x.Select((c, i) => i % 2 > 0 ? char.ToLower(c) : char.ToUpper(c)))));
        }
    }
}