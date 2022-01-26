/*
https://www.codewars.com/kata/588817db5fb13af14a000020/csharp

7 kyu
Simple Fun #40: Timed Reading

Task
Timed Reading is an educational tool used in many schools to improve and advance reading skills. 
A young elementary student has just finished his very first timed reading exercise. 
Unfortunately he's not a very good reader yet, so whenever he encountered a word longer than maxLength, he simply skipped it and read on.

Help the teacher figure out how many words the boy has read by calculating the number of words in the text he has read, no longer than maxLength.

Formally, a word is a substring consisting of English letters, 
such that characters to the left of the leftmost letter and to the right of the rightmost letter are not letters.

Example
For maxLength = 4 and text = "The Fox asked the stork, 'How is the soup?'", the output should be 7

The boy has read the following words: "The", "Fox", "the", "How", "is", "the", "soup".

Input/Output
[input] integer maxLength

A positive integer, the maximum length of the word the boy can read.

Constraints: 1 ≤ maxLength ≤ 10.

[input] string text

A non-empty string of English letters and punctuation marks.

[output] an integer

The number of words the boy has read.
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class SimpleFun40TimedReading
    {
        public int TimedReading(int MaxLength, string text)
        {
            //return Regex.Replace(text, @"[;,\.\?\!']", "").Split(' ').Count(w => w.Any() && w.Length <= max);
            //return text.Split(' ', ',', '.', '!', '\'', '?', '\"').Where(x => x != "").Count(x => x.Length <= MaxLength);

            // string[] separators = {" ", ",", ".", "!", "\'", "?", "\""};
            // return text.Split(separators, StringSplitOptions.RemoveEmptyEntries)
            //     .ToArray()
            //     .Where(x => x.Length <= MaxLength)
            //     .Count();

            //return Regex.Replace(text, @"\p{P}", "").Split().Count(s => s.Length > 0 && s.Length <= MaxLength);
            //return Regex.Matches(text, @"\b\w{1," + MaxLength + @"}\b").Count;
            //return text.Split(' ', '!', '?', '.', ',', '\'').Count(x => x.Length <= MaxLength && x.Length != 0);
            //return Regex.Split(text, @"\W+").Count(i => i.Length <= MaxLength && i.Length > 0);
            //return Regex.Replace(text, "[,!?']", string.Empty).Split(' ').Count(c => c.Length <= MaxLength);
            return Regex.Replace(text, "[,!?']", "").Split().Count(s => s.Length <= MaxLength);
        }
    }
}