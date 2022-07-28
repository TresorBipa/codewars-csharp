/*
https://www.codewars.com/kata/5226eb40316b56c8d500030f/csharp

6 kyu
Pascal's Triangle

In mathematics, Pascal's triangle is a triangular array of the binomial coefficients expressed with formula

(nk)=n!k!(n−k)!\lparen {n \atop k} \rparen = \frac {n!} {k!(n-k)!}( 
k
n
​
 )= 
k!(n−k)!
n!
​
 
where n denotes a row of the triangle, and k is a position of a term in the row.

Pascal's Triangle

You can read Wikipedia article on Pascal's Triangle for more information.

Task
Write a function that, given a depth n, returns n top rows of Pascal's Triangle flattened into a one-dimensional list/array.

Example:
n = 1: [1]
n = 2: [1,  1, 1]
n = 4: [1,  1, 1,  1, 2, 1,  1, 3, 3, 1]

Note
Beware of overflow. Requested terms of a triangle are guaranteed to fit into the returned type, 
but depending on seleced method of calculations, intermediate values can be larger.
*/


using System.Collections.Generic;
using System.Linq;

namespace CodeWars;

public class KataPascalsTriangle
{
    public static List<int> PascalsTriangle(int n)
    {
        var result = new List<int>();
        for (var i = 0; i < n; i++)
        {
            result.Add(1);
            for (var j = 1; j <= i; j++) result.Add(result[^1] * (i + 1 - j) / j);
        }

        return result;
    }
}