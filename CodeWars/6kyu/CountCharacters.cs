/*
https://www.codewars.com/kata/count-characters-in-your-string/csharp
https://www.codewars.com/kata/52efefcbcdf57161d4000091/csharp

6 kyu
Count characters in your string

The main idea is to count all the occurring characters in a string. If you have a string like aba, then the result should be {'a': 2, 'b': 1}.

What if the string is empty? Then the result should be empty object literal, {}.
*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class CountCharacters
    {
        public static Dictionary<char, int> Count(string str)
        {
            // return str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());

            var result = new Dictionary<char, int>();

            foreach (var uniqueChar in str.Distinct())
            {
                var countChar = 0;
                foreach (var ch in str)
                    if (uniqueChar == ch)
                        countChar++;
                result.Add(uniqueChar, countChar);
            }

            return result;
        }
    }
}