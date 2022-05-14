/*
https://www.codewars.com/kata/52f78966747862fc9a0009ae/csharp

6 kyu
Reverse polish notation calculator

Your job is to create a calculator which evaluates expressions in Reverse Polish notation.
For example expression 5 1 2 + 4 * + 3 - (which is equivalent to 5 + ((1 + 2) * 4) - 3 in normal notation) should evaluate to 14.
For your convenience, the input is formatted such that a space is provided between every token.
Empty expression should evaluate to 0.
Valid operations are +, -, *, /.
You may assume that there won't be exceptional situations (like stack underflow or division by zero).
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Data;

namespace CodeWars
{
    public class ReversePolishNotationCalculator
    {
        public double evaluate(string expr)
        {
            var ops = new Dictionary<string, Func<double, double, double>>
            {
                { "+", (a, b) => a + b },
                { "-", (a, b) => b - a },
                { "*", (a, b) => a * b },
                { "/", (a, b) => b / a }
            };

            var stack = new Stack<double>();
            stack.Push(0);

            foreach (var s in expr.Split(" ", StringSplitOptions.RemoveEmptyEntries))
            {
                stack.Push(ops.ContainsKey(s) ? ops[s](stack.Pop(), stack.Pop()) : double.Parse(s));
            }

            return stack.Pop();
        }
    }
}