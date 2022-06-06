/*
https://www.codewars.com/kata/5626b561280a42ecc50000d1/csharp

6 kyu
Take a Number And Sum Its Digits Raised To The Consecutive Powers And ....¡Eureka!!

The number 89 is the first integer with more than one digit that fulfills the property partially introduced in the title of this kata. 
What's the use of saying "Eureka"? Because this sum gives the same number.

In effect: 89 = 8^1 + 9^2

The next number in having this property is 135.

See this property again: 135 = 1^1 + 3^2 + 5^3

We need a function to collect these numbers, that may receive two integers a, b that defines the range [a, b] (inclusive) and outputs a list of the sorted numbers in the range that fulfills the property described above.

Let's see some cases:

sum_dig_pow(1, 10) == [1, 2, 3, 4, 5, 6, 7, 8, 9]

sum_dig_pow(1, 100) == [1, 2, 3, 4, 5, 6, 7, 8, 9, 89]
If there are no numbers of this kind in the range [a, b] the function should output an empty list.

sum_dig_pow(90, 100) == []
Enjoy it!!
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class TakeNumberAndSumItsDigits
    {
        public static long[] SumDigPow(long a, long b)
        {
            // return new long[b - a + 1].Select(z => a++)
            //     .Where(x => x.ToString().Select((y, i) => (long) Math.Pow(y - '0', i + 1)).Sum() == x).ToArray();


            return Enumerable.Range((int) a, (int) (b - a))
                .Where(x => (long) x.ToString().Select((c, i) => Math.Pow(c - '0', i + 1)).Sum() == x)
                .Select(Convert.ToInt64).ToArray();


            // return Enumerable.Range((int) a, (int) (b - a))
            //     .Where(x => (long) x.ToString().Select((c, i) => Math.Pow(long.Parse("" + c), i + 1)).Sum() == x)
            //     .Select(Convert.ToInt64).ToArray();


            // return Enumerable.Range((int) a, (int) (b - a))
            //     .Where(x => (long) x.ToString().Select((c, i) => Math.Pow(char.GetNumericValue(c), i + 1)).Sum() == x)
            //     .Select(Convert.ToInt64).ToArray();


            //Int64.Parse(""+c)

            // var tt = Enumerable.Range((int) a, (int) (b - a))
            //     .Where(x => (long) Enumerable.Range(1, x.ToString().Length)
            //         .Select((i, j) => Math.Pow(long.Parse($"{(i + "")[j]}"), i)).Sum() == x);
            //
            // return tt.ToArray();


            // var result = new List<long>();
            // for (long i = a; i <= b; i++)
            // {
            //     // var r = (int) Enumerable.Range(1, i.ToString().Length)
            //     //     .Select((x, j) => Math.Pow(long.Parse(i.ToString()[j].ToString()), x)).Sum();
            //
            //     var r = (int) Enumerable.Range(1, i.ToString().Length)
            //         .Select((x, j) => Math.Pow(long.Parse($"{(i + "")[j]}"), x)).Sum();
            //
            //     if (i == r)
            //         result.Add(i);
            // }
            //
            // return result.ToArray();
        }
    }
}