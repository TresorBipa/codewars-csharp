﻿/*
https://www.codewars.com/kata/5418a1dd6d8216e18a0012b2/csharp

6 kyu
Validate Credit Card Number

In this Kata, you will implement the Luhn Algorithm, which is used to help validate credit card numbers.

Given a positive integer of up to 16 digits, return true if it is a valid credit card number, and false if it is not.

Here is the algorithm:

Double every other digit, scanning from right to left, starting from the second digit (from the right).

Another way to think about it is: if there are an even number of digits, double every other digit starting with the first; 
if there are an odd number of digits, double every other digit starting with the second:

1714 ==> [1*, 7, 1*, 4] ==> [2, 7, 2, 4]

12345 ==> [1, 2*, 3, 4*, 5] ==> [1, 4, 3, 8, 5]

891 ==> [8, 9*, 1] ==> [8, 18, 1]
If a resulting number is greater than 9, replace it with the sum of its own digits (which is the same as subtracting 9 from it):

[8, 18*, 1] ==> [8, (1+8), 1] ==> [8, 9, 1]

or:

[8, 18*, 1] ==> [8, (18-9), 1] ==> [8, 9, 1]
Sum all of the final digits:

[8, 9, 1] ==> 8 + 9 + 1 = 18
Finally, take that sum and divide it by 10. If the remainder equals zero, the original credit card number is valid.

18 (modulus) 10 ==> 8 , which is not equal to 0, so this is not a valid credit card number
For F# and C# users:

The input will be a string of spaces and digits 0..9
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CodeWars
{
    public class ValidateCreditCardNumber
    {
        public bool validate(string n)
        {
            return n.Where(char.IsDigit)
                .Select(x => int.Parse(x.ToString()))
                .Reverse()
                .Select((x, i) => i % 2 == 0 ? x : x * 2 > 9 ? x * 2 - 9 : x * 2)
                .Sum() % 10 == 0;


            // int[] digits = n.Where(char.IsDigit).Select(x => int.Parse(x.ToString())).ToArray();
            // int sum = 0;
            // int length = digits.Length;
            // for (int i = 0; i < length; i++)
            // {
            //     int digit = digits[length - i - 1];
            //     if (i % 2 == 1) digit *= 2;
            //     sum += digit > 9 ? digit - 9 : digit;
            // }
            //
            // return sum % 10 == 0;
        }
    }
}