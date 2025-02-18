﻿/*
https://www.codewars.com/kata/58235a167a8cb37e1a0000db/csharp

6 kyu
Pair of gloves

Pair of gloves
Winter is coming, you must prepare your ski holidays. 
The objective of this kata is to determine the number of pair of gloves you can constitute from the gloves you have in your drawer.

Given an array describing the color of each glove, return the number of pairs you can constitute, 
assuming that only gloves of the same color can form pairs.

Examples:
input = ["red", "green", "red", "blue", "blue"]
result = 2 (1 red pair + 1 blue pair)

input = ["red", "red", "red", "red", "red", "red"]
result = 3 (3 red pairs)
*/


using System.Linq;

namespace CodeWars._6kyu;

public class PairOfGloves
{
    public static int NumberOfPairs(string[] gloves)
    {
        // return gloves.Distinct().Sum(s => gloves.Count(x => x == s) / 2);
        return gloves.GroupBy(s => s).Sum(g => g.Count() / 2);
    }
}