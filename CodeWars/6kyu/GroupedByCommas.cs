/*
https://www.codewars.com/kata/5274e122fc75c0943d000148/csharp

6 kyu
Grouped by commas

Finish the solution so that it takes an input n (integer) and returns a string that is the decimal representation of the number grouped by commas after every 3 digits.

Assume: 0 <= n < 2147483647

Examples
       1  ->           "1"
      10  ->          "10"
     100  ->         "100"
    1000  ->       "1,000"
   10000  ->      "10,000"
  100000  ->     "100,000"
 1000000  ->   "1,000,000"
35235235  ->  "35,235,235"
*/

using System.Globalization;
using System.Text;

namespace CodeWars
{
    public class GroupedByCommas
    {
        public static string GroupByCommas(int n)
        {
            return $"{n:n0}";
            // return $"{n:N0}";
            // return $"{n:#,#}";
            // return $"{n:###,###,###,###}";


            // NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            // nfi.NumberDecimalDigits = 0;
            // return n.ToString("n0", nfi);


            // var result = n.ToString();
            // for (var i = result.Length - 3; i > 0; i -= 3)
            //     result = result.Insert(i, ",");
            //
            // return result;
        }
    }
}