/*
https://www.codewars.com/kata/57f75cc397d62fc93d000059/csharp

7 kyu
Char Code Calculation

Given a string, turn each character into its ASCII character code and join them together to create a number - let's call this number total1:

'ABC' --> 'A' = 65, 'B' = 66, 'C' = 67 --> 656667
Then replace any incidence of the number 7 with the number 1, and call this number 'total2':

total1 = 656667
              ^
total2 = 656661
              ^
Then return the difference between the sum of the digits in total1 and total2:

  (6 + 5 + 6 + 6 + 6 + 7)
- (6 + 5 + 6 + 6 + 6 + 1)
-------------------------
                       6
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars;

public class CharCodeCalculation
{
    public static int Calc(string s)
    {
        return string.Concat(s.Select(x => (int) x)).Count(x => x == '7') * 6;
        // return s.Aggregate("", (a, c) => a + (int) c).Count(c => c == '7') * 6;

        // var total1 = string.Concat(s.Select(x => (int) x));
        // var total2 = total1.Replace("7", "1");
        // return total1.Sum(x => x - '0') - total2.Sum(x => x - '0');
        // return total1.Sum(x => int.Parse(x.ToString())) - total2.Sum(x => int.Parse(x.ToString()));
    }
}