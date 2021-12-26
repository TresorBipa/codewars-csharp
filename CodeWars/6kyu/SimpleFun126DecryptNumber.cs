﻿/*
https://www.codewars.com/kata/58a3cb34623e8c119d0000d5/csharp

6 kyu
Simple Fun #126: Decrypt Number

Task
Smartphones software security has become a growing concern related to mobile telephony. It is particularly important as it relates to the security of available personal information.

For this reason, Ahmed decided to encrypt phone numbers of contacts in such a way that nobody can decrypt them. At first he tried encryption algorithms very complex, but the decryption process is tedious, especially when he needed to dial a speed dial.

He eventually found the algorithm following: instead of writing the number itself, Ahmed multiplied by 10, then adds the result to the original number.

For example, if the phone number is 123, after the transformation, it becomes 1353. Ahmed truncates the result (from the left), so it has as many digits as the original phone number. In this example Ahmed wrote 353 instead of 123 in his smart phone.

Ahmed needs a program to recover the original phone number from number stored on his phone. The program return "impossible" if the initial number can not be calculated.

Note: There is no left leading zero in either the input or the output; Input s is given by string format, because it may be very huge ;-)

Example
For s="353", the result should be "123"

   1230
 +  123
 .......
 = 1353  
 
 truncates the result to 3 digit -->"353"
 
 So the initial number is "123"
For s="123456", the result should be "738496"

   7384960
 +  738496
 .........
 = 8123456
 
 truncates the result to 6 digit -->"123456"
 
 So the initial number is "738496"
For s="4334", the result should be "impossible"

Because no such a number can be encrypted to "4334".

Input/Output
[input] string s
string presentation of n with 1 <= n <= 10^100

[output] a string
The original phone number before encryption, or "impossible" if the initial number can not be calculated.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace CodeWars
{
    public class SimpleFun126DecryptNumber
    {
        public string Decrypt(string s)
        {
            var n = BigInteger.Divide(
                Enumerable.Range(1, 10).Select(x => BigInteger.Parse(x + s)).FirstOrDefault(x => x % 11 == 0), 11);
            return n == 0 ? "impossible" : n.ToString();

            // var result = new List<int> { s[^1] - '0' };
            // var arr = (0 + s).ToCharArray().Select(x => x - '0').ToArray();
            //
            // for (var i = arr.Length - 1; i > 1; i--)
            // {
            //     var num = arr[i - 1] - result[0];
            //
            //     if (num < 0)
            //     {
            //         num += 10;
            //         arr[i - 2]--;
            //     }
            //
            //     result.Insert(0, num);
            // }
            //
            // return result[0] == 0 ? "impossible" : string.Concat(result);
        }
    }
}


