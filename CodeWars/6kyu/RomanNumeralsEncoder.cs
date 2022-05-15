/*
https://www.codewars.com/kata/51b62bf6a9c58071c600001b/csharp

6 kyu
Roman Numerals Encoder

Create a function taking a positive integer as its parameter and returning a string containing the Roman Numeral representation of that integer.

Modern Roman numerals are written by expressing each digit separately starting with the left most digit and skipping any digit with a value of zero. 
In Roman numerals 1990 is rendered: 
1000=M, 900=CM, 90=XC; resulting in MCMXC. 
2008 is written as 2000=MM, 8=VIII; or MMVIII. 
1666 uses each Roman symbol in descending order: MDCLXVI.

Example:

RomanConvert.Solution(1000) -- should return "M"
Help:

Symbol    Value
I          1
V          5
X          10
L          50
C          100
D          500
M          1,000
Remember that there can't be more than 3 identical symbols in a row.

More about roman numerals - http://en.wikipedia.org/wiki/Roman_numerals
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class RomanNumeralsEncoder
    {
        // static uint[] nums = {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
        // static string[] rum = {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};

        public static string Solution(int n)
        {
            return new Dictionary<int, string>
            {
                {1000, "M"}, {900, "CM"}, {500, "D"}, {400, "CD"},
                {100, "C"}, {90, "XC"}, {50, "L"}, {40, "XL"},
                {10, "X"}, {9, "IX"}, {5, "V"}, {4, "IV"}, {1, "I"}
            }.Where(p => n >= p.Key).Select(p => p.Value + Solution(n - p.Key)).FirstOrDefault();


            // return new Dictionary<int, string>
            // {
            //     {1000, "M"},
            //     {900, "CM"},
            //     {500, "D"},
            //     {400, "CD"},
            //     {100, "C"},
            //     {90, "XC"},
            //     {50, "L"},
            //     {40, "XL"},
            //     {10, "X"},
            //     {9, "IX"},
            //     {5, "V"},
            //     {4, "IV"},
            //     {1, "I"}
            // }.Aggregate(new string('I', n), (m, _) => m.Replace(new string('I', _.Key), _.Value));


            // string value = "";
            // long number = n;
            // for (int i = 0; i < nums.Length && number != 0; i++)
            // {
            //     while (number >= nums[i])
            //     {
            //         number -= nums[i];
            //         value += rum[i];
            //     }
            // }
            //
            // return value;
        }
    }
}