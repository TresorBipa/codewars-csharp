/*
https://www.codewars.com/kata/57f5e7bd60d0a0cfd900032d

7 kyu
Find the Missing Number

This question is a variation on the Arithmetic Progression kata

The following was a question that I received during a technical interview for an entry level software developer position. 
I thought I'd post it here so that everyone could give it a go:

You are given an unsorted array containing all the integers from 0 to 100 inclusively. 
However, one number is missing. Write a function to find and return this number. 
What are the time and space complexities of your solution?
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CodeWars
{
    public class FindMissingNumber
    {
        public static int MissingNo(int[] nums)
        {
            // for (var i = 0; i <= nums.Length; i++)
            // {
            //     if (!nums.Contains(i))
            //     {
            //         return i;
            //     }
            // }
            // return 0;

            // return 5050 - nums.Sum();
            // return 5050 - nums.Aggregate(0, (a, b) => a + b);
            return Enumerable.Range(0, 101).Except(nums).First();
            // return Enumerable.Range(0, 101).Except(nums).ToArray()[0];
            // return Enumerable.Range(0, 101).Sum() - nums.Aggregate(0, (a, b) => a + b);
        }
    }
}


