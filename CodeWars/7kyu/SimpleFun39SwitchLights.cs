﻿/*
https://www.codewars.com/kata/5888145122fe8620950000f0/csharp

7 kyu
Simple Fun #39: Switch Lights

Task
N candles are placed in a row, some of them are initially lit. 
For each candle from the 1st to the Nth the following algorithm is applied: 
if the observed candle is lit then states of this candle and all candles before it are changed to the opposite. 
Which candles will remain lit after applying the algorithm to all candles in the order they are placed in the line?

Example
For a = [1, 1, 1, 1, 1], the output should be [0, 1, 0, 1, 0].

Check out the image below for better understanding:

For a = [0, 0], the output should be [0, 0].

The candles are not initially lit, so their states are not altered by the algorithm.

Input/Output
[input] integer array a

Initial situation - array of zeros and ones of length N, 1 means that the corresponding candle is lit.

Constraints: 2 ≤ a.length ≤ 5000.

[output] an integer array

Situation after applying the algorithm - array in the same format as input with the same length.
*/

using System.Linq;

namespace CodeWars
{
    public class SimpleFun39SwitchLights
    {
        public int[] SwitchLights(int[] a)
        {
            var result = new int[a.Length];

            var sum = a.Sum();
            for (var i = 0; i < a.Length; i++)
            {
                var value = a[i];
                result[i] = (value + sum) % 2;
                sum -= value;
            }

            return result;
        }
    }
}