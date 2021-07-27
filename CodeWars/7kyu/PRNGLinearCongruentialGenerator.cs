/*
https://www.codewars.com/kata/594979a364becbc1ab00003a/csharp

7 kyu
PRNG: Linear Congruential Generator

The Linear Congruential Generator (LCG) is one of the oldest pseudo random number generator functions.

The algorithm is as follows:

Xn+1=(aXn + c) mod m
where:

a/A is the multiplier (we'll be using 2)
c/C is the increment (we'll be using 3)
m/M is the modulus (we'll be using 10)
X0 is the seed.

Your task
Define a method random/Random in the class LCG that provides the next random number based on a seed. 
You never return the initial seed value.

Similar to random return the result as a floating point number in the range [0.0, 1.0)

Example
LCG myLCG = new LCG(5); // Initialize the generator with a seed of 5
myLCG.Random(); // => 0.3 ((2 * 5 + 3) mod 10 = 3)
myLCG.Random(); // => 0.9 ((2 * 3 + 3) mod 10 = 9)
myLCG.Random(); // => 0.1 ((2 * 9 + 3) mod 10 = 1)
myLCG.Random(); // => 0.5 ((2 * 1 + 3) mod 10 = 5)
*/

using System;

namespace CodeWars
{
    public class PRNGLinearCongruentialGenerator
    {
        private const int A = 2;
        private const int C = 3;
        private const int M = 10;
        private int X;

        // public LCG(int x)
        public PRNGLinearCongruentialGenerator(int x) => X = x;
        public double Random() => (double) (X = (A * X + C) % M) / M;
    }
}