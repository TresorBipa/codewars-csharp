/*
https://www.codewars.com/kata/526a569ca578d7e6e300034e/csharp

6 kyu
Base Conversion

In this kata you have to implement a base converter, 
which converts positive integers between arbitrary bases / alphabets. Here are some pre-defined alphabets:

public class Alphabet
{
   public const string BINARY = "01";
   public const string OCTAL = "01234567";
   public const string DECIMAL = "0123456789";
   public const string HEXA_DECIMAL = "0123456789abcdef";
   public const string ALPHA_LOWER = "abcdefghijklmnopqrstuvwxyz";
   public const string ALPHA_UPPER = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
   public const string ALPHA = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
   public const string ALPHA_NUMERIC = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
}
The function convert() should take an input (string), the source alphabet (string) and the target alphabet (string). 
You can assume that the input value always consists of characters from the source alphabet. You don't need to validate it.

Examples
// convert between numeral systems
Convert("15", Alphabet.DECIMAL, Alphabet.BINARY); // should return "1111"
Convert("15", Alphabet.DECIMAL, Alphabet.OCTAL); // should return "17"
Convert("1010", Alphabet.BINARY, Alphabet.DECIMAL); // should return "10"
Convert("1010", Alphabet.BINARY, Alphabet.HEXA_DECIMAL); // should return "a"

// other bases
Convert("0", Alphabet.DECIMAL, Alphabet.ALPHA); // should return "a"
Convert("27", Alphabet.DECIMAL, Alphabet.ALPHA_LOWER); // should return "bb"
Convert("hello", Alphabet.ALPHA_LOWER, Alphabet.HEXA_DECIMAL); // should return "320048"
Convert("SAME", Alphabet.ALPHA_UPPER, Alphabet.ALPHA_UPPER); // should return "SAME"
Additional Notes:

The maximum input value can always be encoded in a number without loss of precision in JavaScript. 
In Haskell, intermediate results will probably be too large for Int.
The function must work for any arbitrary alphabets, not only the pre-defined ones
You don't have to consider negative numbers
*/

using System;
using System.Linq;
using System.Text;

namespace CodeWars
{
    public class BaseConversion
    {
        public class Alphabet
        {
            public const string BINARY = "01";
            public const string OCTAL = "01234567";
            public const string DECIMAL = "0123456789";
            public const string HEXA_DECIMAL = "0123456789abcdef";
            public const string ALPHA_LOWER = "abcdefghijklmnopqrstuvwxyz";
            public const string ALPHA_UPPER = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            public const string ALPHA = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            public const string ALPHA_NUMERIC = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }

        public string Convert(string input, string source, string target)
        {
            var result = "";
            var num = input.Select((c, i) => source.IndexOf(c) * (long) Math.Pow(source.Length, input.Length - i - 1))
                .Sum();

            do
            {
                result = target[(int) (num % target.Length)] + result;
            } while ((num /= target.Length) > 0);

            return result;
        }
    }
}