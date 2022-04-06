/*
https://www.codewars.com/kata/57ea70aa5500adfe8a000110/csharp

6 kyu
Fold an array

In this kata you have to write a method that folds a given array of integers by the middle x-times.

An example says more than thousand words:

Fold 1-times:
[1,2,3,4,5] -> [6,6,3]

A little visualization (NOT for the algorithm but for the idea of folding):

 Step 1         Step 2        Step 3       Step 4       Step5
                     5/           5|         5\          
                    4/            4|          4\      
1 2 3 4 5      1 2 3/         1 2 3|       1 2 3\       6 6 3
----*----      ----*          ----*        ----*        ----*


Fold 2-times:
[1,2,3,4,5] -> [9,6]
As you see, if the count of numbers is odd, the middle number will stay. 
Otherwise the fold-point is between the middle-numbers, so all numbers would be added in a way.

The array will always contain numbers and will never be null. 
The parameter runs will always be a positive integer greater than 0 and says how many runs of folding your method has to do.

If an array with one element is folded, it stays as the same array.

The input array should not be modified!

Have fun coding it and please don't forget to vote and rank this kata! :-)

I have created other katas. Have a look if you like coding and challenges.
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CodeWars
{
    public class KataFoldAnArray
    {
        public static int[] FoldArray(int[] array, int runs)
        {
            return runs == 0
                ? array
                : FoldArray(Enumerable.Range(0, array.Length / 2)
                    .Select(i => array[i] + array[array.Length - i - 1])
                    .Concat(array.Length % 2 == 0 ? new int[] { } : new[] { array[array.Length / 2] })
                    .ToArray(), runs - 1);


            // int len = (int)Math.Ceiling(array.Length / 2d);
            // int[] fold = new int[len];
            // Array.Copy(array, fold, len);
            // for (int i = 0; i < array.Length / 2; i++)
            // {
            //     fold[i] += array[array.Length - 1 - i];
            // }
            //
            // return fold.Length == 1 | runs == 1 ? fold : FoldArray(fold, --runs);
        }
    }
}