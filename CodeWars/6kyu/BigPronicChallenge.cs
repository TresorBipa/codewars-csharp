/*
https://www.codewars.com/kata/55f160df93f61bb26b00002a/csharp

6 kyu
The BIG Pronic challenge

A pronic number is a composite integer that is the product of two consecutive integers -- in other words, every pronic number can be calculated as either n(n+1) or n(n-1) where n is any integer. 
A related kata Figurate Numbers #2 - Pronic Number was fun and for the 32-bit integer problem space, a simple search-loop made solving that kata possible and a clever formula eliminated the need for a loop altogether.

This challenge will be different - this challenge is to write code that determines whether big -- REALLY BIG -- numbers are pronic. 
A naive loop through a billion or so numbers isn't going to work here. 
Provided is a non-loop based starter solution that generally works in the linked kata, but fails for the bigger data passed here.

Detail
The tests you see are all you need to pass. There are no surprise tests to pass after the original tests are passing.
These tests run your algorithm through over 300,000 numbers -- some pronic and some non-pronic. 
If your algorithm is reasonable, it should take considerably less than 6 seconds to complete.
While authoring this kata, a couple large valued test-cases produced calculated pronics that appeared to be either much smaller than they should have or in some cases they even resulted in negative values. 
This was due to overflow and unchecked math, so checked block safeguards have been added to the tests to prevent accidental overflow for new and existing test-cases.
*/


using System;

namespace CodeWars._6kyu
{
    public static class BigPronicChallenge
    {
        public static bool IsPronic(long n)
        {
            return n >= 0 && (long) Math.Sqrt(n) * ((long) Math.Sqrt(n) + 1) == n;
            // return n != long.MinValue && (long) Math.Sqrt(n) * ((long) Math.Sqrt(n) + 1) == n;
        }
    }
}