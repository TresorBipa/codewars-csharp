/*
https://www.codewars.com/kata/60d5b5cd507957000d08e673/csharp

6 kyu
Nth Order Summation

Task
Consider a series of functions Sm(n)S_m(n)S 
m
​
 (n) where:

S0(n)=1S_0(n) = 1S 
0
​
 (n)=1
Sm+1(n)=∑k=1nSm(k)S_{m+1}(n) = \displaystyle\sum^n_{k=1}S_m(k)S 
m+1
​
 (n)= 
k=1
∑
n
​
 S 
m
​
 (k)

Write a function s which takes two integer arguments m and n and returns the value defined by Sm(n)S_m(n)S 
m
​
 (n).

Inputs
0 <= m <= 100
1 <= n <= 10**100
*/


using System.Numerics;

namespace CodeWars
{
    public static class NthOrderSummation
    {
        public static BigInteger S(BigInteger m, BigInteger n)
        {
            BigInteger result = 1;
            for (BigInteger i = 0; i < m; i++)
            {
                result *= n + i;
                result /= 1 + i;
            }

            return result;
        }
    }
}