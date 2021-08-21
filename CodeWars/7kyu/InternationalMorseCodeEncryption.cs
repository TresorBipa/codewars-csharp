/*
https://www.codewars.com/kata/55b8c0276a7930249e00003c/csharp

7 kyu
International Morse Code Encryption

Write a function that will encrypt a given sentence into International Morse Code, both the input and out puts will be strings.

Characters should be separated by a single space. Words should be separated by a triple space.

For example, "HELLO WORLD" should return -> ".... . .-.. .-.. --- .-- --- .-. .-.. -.."

To find out more about Morse Code follow this link: https://en.wikipedia.org/wiki/Morse_code

A preloaded object/dictionary/hash called CHAR_TO_MORSE will be provided to help convert characters to Morse Code.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class InternationalMorseCodeEncryption
    {
        public static Dictionary<char, string> CHAR_TO_MORSE = new Dictionary<char, string>
        {
            {'0', "-----"}, {'1', ".----"}, {'2', "..---"}, {'3', "...--"}, {'4', "....-"}, {'5', "....."},
            {'6', "-...."}, {'7', "--..."}, {'8', "---.."}, {'9', "----."}, {'a', ".-"}, {'h', "...."}, {'o', "---"},
            {'u', "..-"}, {'b', "-..."}, {'i', ".."}, {'p', ".--."}, {'v', "...-"}, {'c', "-.-."}, {'j', ".---"},
            {'q', "--.-"}, {'w', ".--"}, {'d', "-.."}, {'k', "-.-"}, {'r', ".-."}, {'x', "-..-"}, {'e', "."},
            {'l', ".-.."}, {'s', "..."}, {'y', "-.--"}, {'f', "..-."}, {'m', "--"}, {'t', "-"}, {'z', "--.."},
            {'g', "--."}, {'n', "-."}, {'A', ".-"}, {'H', "...."}, {'O', "---"}, {'U', "..-"}, {'B', "-..."},
            {'I', ".."}, {'P', ".--."}, {'V', "...-"}, {'C', "-.-."}, {'J', ".---"}, {'Q', "--.-"}, {'W', ".--"},
            {'D', "-.."}, {'K', "-.-"}, {'R', ".-."}, {'X', "-..-"}, {'E', "."}, {'L', ".-.."}, {'S', "..."},
            {'Y', "-.--"}, {'F', "..-."}, {'M', "--"}, {'T', "-"}, {'Z', "--.."}, {'G', "--."}, {'N', "-."}
        };

        public static string ToMorse(string englishStr)
        {
            return string.Join(" ", englishStr.Select(c => c == ' ' ? " " : CHAR_TO_MORSE[c]));

            // return string.Join(" ",
            //     englishStr.Select(c => CHAR_TO_MORSE.ContainsKey(c) ? CHAR_TO_MORSE[c] : c.ToString()));
        }
    }
}