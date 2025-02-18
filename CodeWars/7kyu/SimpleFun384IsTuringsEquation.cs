﻿/*
https://www.codewars.com/kata/5a1e6323ffe75f71ae000026/csharp

7 kyu
Simple Fun #384: Is Turing's Equation?

Story
Joe Stoy, in his book "Denotational Semantics", tells following story:

The decision which way round the digits run is, of course, mathematically trivial.
Indeed, one early British computer had numbers running from right to left (because
the spot on an oscilloscope tube runs from left to right, but in serial logic the
least significant digits are dealt with first). 

Turing used to mystify audiences at public lectures when, quite by accident, he would 
slip into this mode even for decimal arithmetic, and write things like 73+42=16.

The next version of the machine was made more conventional simply by crossing the
x-deflection wires: this, however, worried the engineers, whose waveforms were all
backwards. That problem was in turn solved by providing a little window so that the 
engineers(who tended to be behind the computer anyway) could view the oscilloscope
screen from the back. 

[C. Strachey - private communication.]
You will play the role of the audience and judge on the truth value of Turing's equations.

Task
You are given a string s. It's an equation such as "a+b=c", where a, b, c are numbers made up of the digits 0 to 9. This includes possible leading or trailing zeros. The equations will not contain any spaces.

Your task is to determine whether s is a valid Turing equation. Return true or false, respectively, in Turing's interpretation, i.e. the numbers being read backwards.

Still struggling to understand the task? Look at the following examples ;-)

Examples
For s = "73+42=16", the output should be true.

73 -> 37
42 -> 24
61 -> 61
37+24==61
For s = "5+8=13", the output should be false.

5 -> 5
8 -> 8
13 -> 31
5+8!=31
For s = "10+20=30", the output should be true.

10 -> 01 -> 1
20 -> 02 -> 2
30 -> 03 -> 3
1+2==3
Note
All the numbers a,b,c no more than 10 digits, excluding leading zeros(read backwards)

s contains only digits, "+" and "=", "-","*" or "/" will not appear in the string.

Happy Coding ^_^
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class SimpleFun384IsTuringsEquation
    {
        public static bool IsTuringEquation(string str)
        {
            return ("-" + string.Concat(str.Reverse())).Split('=', '+').Select(s => int.Parse(s.ToString())).Sum() == 0;

            // string[] nums = string.Concat(str.Reverse()).Replace('=', '+').Split('+');
            // return int.Parse(nums[0]) == int.Parse(nums[1]) + int.Parse(nums[2]);

            // var tokens = str.Split('+', '=').Select(s => int.Parse(string.Concat(s.Reverse()))).ToArray();
            // return tokens[0] + tokens[1] == tokens[2];

            // return 0 == Regex.Matches(string.Concat(str.Reverse()), @"\d+")
            //     .Select((x, i) => Convert.ToInt32(x.ToString()) * (i == 0 ? -1 : 1))
            //     .Sum();
        }
    }
}