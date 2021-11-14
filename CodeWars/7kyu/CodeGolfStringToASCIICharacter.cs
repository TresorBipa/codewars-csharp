/*
https://www.codewars.com/kata/5abbb33396194245d5000161/

7 kyu
[Code Golf] String to ASCII Character

You are given a string. Your job is to convert that string to upper case, 
then find the sum of each character converted to its ASCII value, 
then divide the sum by the string's length and round it down then convert that to its equivalent character in ASCII.

Note: do it in less than 60 characters

Examples
"abc"  -->  "B"
"asd"  -->  "H"
"iamareallyreallylongstringthatiscompletelyworthlessandisheretostophardcoders"  -->  "L"
*/

using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class CodeGolfStringToASCIICharacter
    {
        public char Solution(string s) => (char)(s.ToUpper().Sum(x => x) / s.Length);
    }
}