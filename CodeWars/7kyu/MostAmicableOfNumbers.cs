/*
https://www.codewars.com/kata/56b5ebaa26fd54188b000018/csharp

7 kyu
The Most Amicable of Numbers

Amicable numbers are two different numbers so related that the sum of the proper divisors of each is equal to the other number. 
(A proper divisor of a number is a positive factor of that number other than the number itself. 
For example, the proper divisors of 6 are 1, 2, and 3.)

For example, the smallest pair of amicable numbers is (220, 284); 
for the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110, of which the sum is 284; 
and the proper divisors of 284 are 1, 2, 4, 71 and 142, of which the sum is 220.

Derive function amicableNumbers(num1, num2) which returns true/True if pair num1 num2 are amicable, false/False if not.

See more at https://en.wikipedia.org/wiki/Amicable_numbers
*/

using System.Linq;

namespace CodeWars
{
    public class MostAmicableOfNumbers
    {
        public static bool AmicableNumbers(int num1, int num2)
        {
            return Enumerable.Range(1, num1 - 1).Where(i => num1 % i == 0).Sum() == num2;

            // return Enumerable.Range(1, num1).Where(i => num1 % i == 0).Sum() ==
            //        Enumerable.Range(1, num2).Where(i => num2 % i == 0).Sum();

            // return Enumerable.Range(1, num1 / 2).Where(x => num1 % x == 0).Sum() == num2 &&
            //        Enumerable.Range(1, num2 / 2).Where(x => num2 % x == 0).Sum() == num1;
        }
    }
}