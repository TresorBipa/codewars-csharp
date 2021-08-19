/*
https://www.codewars.com/kata/5af2b240d2ee2764420000a2/csharp

7 kyu
Infinitely Nested Radicals

Hello,

I am Jomo Pipi

and today we will be evaluating an expression like this:

(there are an infinite number of radicals)

x+x+x+x+⋯\sqrt{x + \sqrt{x + \sqrt{x + \sqrt{x + \cdots}}}} 
x+ 
x+ 
x+ 
x+⋯
​	
 
​	
 
​	
 
​	
 

for a given value x

Simple!

arguments passed in will be 1 or greater

(Check out my other kata!)

Matrix Diagonal Sort OMG

String -> N iterations -> String

String -> X iterations -> String

ANTISTRING

Array - squareUp b!

Matrix - squareUp b!

Infinitely Nested Radical Expressions

pipi Numbers!

*/

using System;

namespace CodeWars
{
    public class InfinitelyNestedRadicals
    {
        public static double evaluateFunction(int x)
        {
            //return Math.Sqrt(x + .25) + .5;
            return Math.Sqrt(x + 0.25) + 0.5;

            //return (Math.Sqrt(4 * x + 1) + 1) / 2;
            //return (1 + Math.Sqrt(1 + 4 * x)) / 2;
            //return (1 + Math.Sqrt(1 + 4 * x)) / 2;
            //return 0.5 * (1.0 + Math.Sqrt(4.0 * x + 1.0));

            // var result = Math.Sqrt(x);
            // for (int i = 0; i < 100; i++)
            // {
            //     result = Math.Sqrt(result + x);
            // }
            // return result;
        }
    }
}