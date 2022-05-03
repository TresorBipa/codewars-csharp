/*
https://www.codewars.com/kata/530d0298e09e54a3620006c2/csharp

6 kyu
Palindromes Below

The aim of this Kata is to modify the Fixnum ( JS: Number CS: extension for int) class to give it the palindrome_below ( JS: palindromeBelow CS: PalindromeBelow ) method. 
This method returns all numbers from and including 1 up to but not including itself that are palindromes for a given base.

For example in base 2 (binary)

1 = "1"
2 = "10"
3 = "11"
4 = "100"
Therefore 1 and 3 are palindromes in base two and the method should return the following.

    5.PalindromeBelow(2)
    => [1, 3]
*/


using System.Linq;

namespace CodeWars._6kyu
{
    public static class PalindromesBelow
    {
        private const string Chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static int[] PalindromeBelow(this int number, int baseValue)
        {
            bool IsPalindromes(int value)
            {
                var s = "";
                while (value > 0)
                {
                    var i = value % baseValue;
                    value = (value - i) / baseValue;
                    s += Chars[i];
                }

                return string.Concat(s.Reverse()) == s;
            }

            return Enumerable.Range(1, number - 1).Where(IsPalindromes).ToArray();
        }
    }
}


