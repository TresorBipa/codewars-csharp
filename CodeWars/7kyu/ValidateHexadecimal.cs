/*
https://www.codewars.com/kata/55a5a70c81e8541d990000bd/csharp

7 kyu
Validate Hexadecimal

Create a function to validate if a string is a valid hexadecimal.
Two patterns is valid

6 chars (ff00ff)
3 chars (f0f).
*/

using System.Text.RegularExpressions;

namespace CodeWars
{
    public class ValidateHexadecimal
    {
        public bool IsHex(string hex)
        {
            return Regex.IsMatch(hex, @"^(?i)([a-f\d]{3}){1,2}$");
        }
    }
}