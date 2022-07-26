/*
https://www.codewars.com/kata/522551eee9abb932420004a0/csharp

6 kyu
N-th Fibonacci

I love Fibonacci numbers in general, but I must admit I love some more than others.

I would like for you to write me a function that when given a number (n) returns the n-th number in the Fibonacci Sequence.

For example:

   NthFib(4) == 2
Because 2 is the 4th number in the Fibonacci Sequence.

For reference, the first two numbers in the Fibonacci sequence are 0 and 1, and each subsequent number is the sum of the previous two.
*/


namespace CodeWars;

public class NThFibonacci
{
    public int NthFib(int n)
    {
        return n > 2 ? NthFib(n - 1) + NthFib(n - 2) : n - 1;


        // return n switch
        // {
        //     1 => 0,
        //     2 => 1,
        //     _ => NthFib(n - 2) + NthFib(n - 1)
        // };


        // int cur = 0;
        // int next = 1;
        // while (--n > 0)
        // {
        //     next += cur;
        //     cur = next - cur;
        // }
        //
        // return cur;
    }
}