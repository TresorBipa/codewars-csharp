/*
https://www.codewars.com/kata/5fc7d2d2682ff3000e1a3fbc/csharp

6 kyu
Message Validator

In this kata, you have an input string and you should check whether it is a valid message. 
To decide that, you need to split the string by the numbers, and then compare the numbers with the number of characters in the following substring.

For example "3hey5hello2hi" should be split into 3, hey, 5, hello, 2, 
hi and the function should return true, because "hey" is 3 characters, 
"hello" is 5, and "hi" is 2; as the numbers and the character counts match, the result is true.

Notes:

Messages are composed of only letters and digits
Numbers may have multiple digits: e.g. "4code13hellocodewars" is a valid message
Every number must match the number of character in the following substring, otherwise the message is invalid: e.g. "hello5" and "2hi2" are invalid
If the message is an empty string, you should return true
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class MessageValidator
    {
        public static bool isAValidMessage(string message)
        {
            // Console.WriteLine(message);

            return Regex.Matches(message, @"(?<d>[\d]+)(?<w>[\D]+)?")
                .All(m => int.Parse(m.Groups["d"].Value) == m.Groups["w"].Value.Length);


            // return Regex.Matches(message, @"(?<num>[\d]+)(?<word>[a-zA-Z]+)?")
            //     .All(x => int.TryParse(x.Groups["num"].Value, out int parsed)
            //               && (x.Groups["word"].Value.Length == parsed));

            // return Regex.Matches(message, @"(?<d>[\d]*)(?<s>[a-z]*)", RegexOptions.IgnoreCase)
            //     .All(x =>
            //         {
            //             int.TryParse(x.Groups["d"].Value, out int res);
            //             return x.Groups["s"].Value.Length == res;
            //         }
            //     );

            // return Regex.IsMatch(message, @"^((\d+)(\D+))*$") &&
            //        Regex.Matches(message, @"(\d+)(\D+)")
            //            .All(x => int.Parse(x.Groups[1].Value) == x.Groups[2].Value.Length);
        }
    }
}