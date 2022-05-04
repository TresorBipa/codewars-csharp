/*
https://www.codewars.com/kata/559536379512a64472000053/csharp

6 kyu
Playing with passphrases

Everyone knows passphrases. 
One can choose passphrases from poems, songs, movies names and so on but frequently they can be guessed due to common cultural references. 
You can get your passphrases stronger by different means. One is the following:

choose a text in capital letters including or not digits and non alphabetic characters,

shift each letter by a given number but the transformed letter must be a letter (circular shift),
replace each digit by its complement to 9,
keep such as non alphabetic and non digit characters,
downcase each letter in odd position, upcase each letter in even position (the first character is in position 0),
reverse the whole result.
Example:
your text: "BORN IN 2015!", shift 1

1 + 2 + 3 -> "CPSO JO 7984!"
4 "CpSo jO 7984!"
5 "!4897 Oj oSpC"

With longer passphrases it's better to have a small and easy program. Would you write it?

https://en.wikipedia.org/wiki/Passphrase
*/

using System;
using System.Linq;
using System.Text;

namespace CodeWars
{
    public class PlayingWithPassphrases
    {
        public static string playPass(string s, int n)
        {
            return string.Concat(s.ToUpper().Select((c, i) =>
                (char)(char.IsLetter(c) ? (c - 65 + n) % 26 + 65 + i % 2 * 32
                    : char.IsDigit(c) ? 9 - c + 96 : c)).Reverse());

            // return string.Concat(s.ToUpper().Select((c, i) =>
            //     (char)(char.IsLetter(c) ? (c - 65 + n) % 26 + (i % 2 == 1 ? 97 : 65) :
            //         char.IsDigit(c) ? 9 - c + 96 : c)).Reverse());

            // return string.Concat(s.ToUpper()
            //     .Select(c =>
            //         char.IsLetter(c) ? (char)((c - 65 + n) % 26 + 65) :
            //         char.IsDigit(c) ? (char)(9 - c + 96) : c)
            //     // char.IsDigit(c) ? (char)(9 - (c - '0') + 48) : c)
            //     .Select((c, i) => i % 2 == 0 ? char.ToUpper(c) : char.ToLower(c))
            //     .Reverse());
        }
    }
}