/*
https://www.codewars.com/kata/56b71974bd06e679a800090b/csharp

6 kyu
Easy, but Crazy Calculator

Your task is to implement the Crazy Calculator.
It's not too difficult, but there are some things you have to consider...

So what to do?

Input: String/Formula which has to be calculated

1. Contains only positive numbers (integers)
2. Contains only "+","-","*" and "/" as operators, no brackets
3. Operator priority as usual "*","/" > "+","-"
4. No tricks, no bad cases, only correct input strings
5. Consider that the results could be doubles
6. What is crazy? You have use "*" instead of "/" and "+" instead of "-" and reverse. So 12/2 = 24 and 5-3=8...
Some easy examples:

Input: "12/2+4*2-5"
Output: 27

Input: "100*5/2-10"
Output: 50

Input: "15*2"
Output: 7.5
First there are some static tests, later on random tests too...


Hope you have fun:-)!
*/


using System;
using System.Data;

namespace CodeWars._6kyu;

public class EasyButCrazyCalculator
{
    public double crazyCalculate(string input)
    {
        input = input.Replace("+", "#")
            .Replace("-", "+")
            .Replace("#", "-")
            .Replace("*", "#")
            .Replace("/", "*")
            .Replace("#", "/");

        return Convert.ToDouble(new DataTable().Compute(input, null));
    }
}