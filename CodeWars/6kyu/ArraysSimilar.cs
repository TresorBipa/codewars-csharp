/*
https://www.codewars.com/kata/51e704f2d8dbace389000279

6 kyu
Arrays Similar

Write a function that determines whether the passed in arrays are similar. 
Similar means they contain the same elements, and the same number of occurrences of elements.

var arr1 = [1, 2, 2, 3, 4],
    arr2 = [2, 1, 2, 4, 3],
    arr3 = [1, 2, 3, 4],
    arr4 = [1, 2, 3, "4"]

arraysSimilar(arr1, arr2); // Should equal true
arraysSimilar(arr2, arr3); // Should equal false
arraysSimilar(arr3, arr4); // Should equal false
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CodeWars
{
    public class KataArraysSimilar
    {
        public static bool ArraysSimilar(object[] arr1, object[] arr2)
        {
            if (arr1.Length != arr2.Length) return false;

            var objArr1 = arr1.OrderBy(x => x.ToString());
            var objArr2 = arr2.OrderBy(x => x.ToString());

            return objArr1.Zip(objArr2, (x, y) => x.Equals(y)).All(x => x);
        }
    }
}

