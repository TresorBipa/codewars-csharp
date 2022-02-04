/*
https://www.codewars.com/kata/55e785dfcb59864f200000d9/csharp

6 kyu
Special Multiples

Some numbers have the property to be divisible by 2 and 3. 
Other smaller subset of numbers have the property to be divisible by 2, 3 and 5. 
Another subset with less abundant numbers may be divisible by 2, 3, 5 and 7. 
These numbers have something in common: their prime factors are contiguous primes.

Implement a function that finds the amount of numbers that have the first N primes as factors below a given limit.

Let's see some cases:

count_specMult(3, 200)  =>  6 

The first 3 primes are: 2, 3 and 5.

And the found numbers below 200 are: 30, 60, 90, 120, 150, 180.
Happy coding!!
*/


using System.Linq;

namespace CodeWars._6kyu
{
    public static class SpecialMultiples
    {
        public static long CountSpecMult(long n, long mxval)
        {
            return (long) (mxval / new double[] {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37}.Take((int) n)
                .Aggregate(1d, (x, y) => x * y));
        }
    }
}