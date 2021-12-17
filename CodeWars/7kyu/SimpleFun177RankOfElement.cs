/*
https://www.codewars.com/kata/58b8cc7e8e7121740700002d/csharp

7 kyu
Simple Fun #177: Rank Of Element

Task
Given an array arr, find the rank of the element at the ith position.

The rank of the arr[i] is a value equal to the number of elements less than or equal to arr[i] standing before arr[i], 
plus the number of elements less than arr[i] standing after arr[i].

Example
For arr = [2,1,2,1,2], i = 2, the result should be 3.

There are 2 elements less than or equal to arr[2] standing before arr[2]:

arr[0] <= arr[2]

arr[1] <= arr[2]

There is only 1 element less than arr[2] standing after arr[2]:

arr[3] < arr[2]

So the result is 2 + 1 = 3.

Input/Output
[input] integer array arr

An array of integers.

3 <= arr.length <= 50.

[input] integer i

Index of the element whose rank is to be found.

[output] an integer

Rank of the element at the ith position.
*/

using System.Linq;

namespace CodeWars
{
    public class SimpleFun177RankOfElement
    {
        public int RankOfElement(int[] arr, int i)
        {
            // return arr.Take(i).Count(x => x <= arr[i]) + arr.Skip(i + 1).Count(x => x < arr[i]);
            // return arr.Where((x, j) => j < i ? arr[j] <= arr[i] : arr[j] < arr[i]).Count();
            return arr.Where((x, n) => x < arr[i] + (n < i ? 1 : 0)).Count();
        }
    }
}