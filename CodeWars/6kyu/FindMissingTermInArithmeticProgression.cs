/*
https://www.codewars.com/kata/52de553ebb55d1fca3000371/csharp

6 kyu
Find the missing term in an Arithmetic Progression

An Arithmetic Progression is defined as one in which there is a constant difference between the consecutive terms of a given series of numbers. 
You are provided with consecutive elements of an Arithmetic Progression. 
There is however one hitch: 
exactly one term from the original series is missing from the set of numbers which have been given to you. 
The rest of the given series is the same as the original AP. 
Find the missing term.

You have to write a function that receives a list, list size will always be at least 3 numbers. 
The missing term will never be the first or last one.

Example
Kata.FindMissing(new List<int> {1, 3, 5, 9, 11}) => 7

PS: This is a sample question of the facebook engineer challenge on interviewstreet. 
I found it quite fun to solve on paper using math, derive the algo that way. Have fun!
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class FindMissingTermInArithmeticProgression
    {
        public static int FindMissing(List<int> list)
        {
            var step = (list.Max() - list.Min()) / list.Count;
            return list.First(i => !list.Contains(i + step)) + step;


            // var step = (list.Last() - list.First()) / list.Count;
            // return list.Select(x => x + step).ToList().Except(list).First();


            // return (int)((long)(list[0] + list[^1]) * (list.Count + 1) / 2 - list.Select(x => (long)x).Sum());


            // var step = (list.Last() - list.First()) / list.Count;
            // var arr = new List<int>();
            // for (int i = list.Min(); i <= list.Max(); i += step)
            // {
            //     arr.Add(i);
            // }
            // return arr.Except(list).First();
        }
    }
}