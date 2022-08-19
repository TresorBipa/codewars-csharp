/*
https://www.codewars.com/kata/569792aa413feea7b3000036/csharp

6 kyu
Basics 01: Convert any Number (Double) to Fraction

Your task is to convert any number (double) to a reduced fraction.
Here it's easy, because the range for numerator and denominator is very restricted (perhaps you can try... and find;-))
 
No tricks, no forced errors, 
really each input number is a "Double" and the tested range for the results is restricted for numerator from [-2000,2000] and denominator [1,2000].

Doubles like 0.3333333333333 have to be interpreted as 1/3 (precision 0.000000001). 
You don't have to convert "4/3" to "1 1/3", but for example you have to reduce "2/4" to "1/2".
 
Only some easy examples - i think it's clear:

0.5 = "1/2"
-2.5 = "-5/2"
0.66666666666 = "2/3"
2 = "2"
-0.618103448275862 =  "-717/1160"

Notes:
The "Run Tests" contain some static tests, the "Submit Tests" contain many random tests too.
Perhaps you can use your function as solution- part of my much more difficult kata: Linear equations N x M, 
complete solution space, fraction representation

Good luck and hope you have fun;-)!
*/


using System;

namespace CodeWars._6kyu;

public class Basics01ConvertAnyNumber
{
    public string toFraction(double number)
    {
        if (number % 1 == 0)
            return number.ToString();

        for (var i = 1;; i++)
        {
            var x = number / (1.0 / i);
            if (Math.Abs(x - Math.Round(x)) < 0.0001)
                return $"{Math.Round(x)}/{i}";
        }
    }
}