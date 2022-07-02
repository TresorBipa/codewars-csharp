/*
https://www.codewars.com/kata/52fb87703c1351ebd200081f/csharp

6 kyu
What century is it?

Return the century of the input year. 
The input will always be a 4 digit string, so there is no need for validation.

Examples
"1999" --> "20th"
"2011" --> "21st"
"2154" --> "22nd"
"2259" --> "23rd"
"1124" --> "12th"
"2000" --> "20th"
*/

namespace CodeWars._6kyu;

public class WhatCenturyIsIt
{
    public static string WhatCentury(string year)
    {
        // var c = (int.Parse(year) - 1) / 100 + 1;
        // return $"{c}{c switch {< 20 => "th", _ => (c % 10) switch {1 => "st", 2 => "nd", 3 => "rd", _ => "th"}}}";


        var c = (int.Parse(year) - 1) / 100 + 1;
        return c + c switch
        {
            < 20 => "th",
            _ => (c % 10) switch
            {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th"
            }
        };
    }
}