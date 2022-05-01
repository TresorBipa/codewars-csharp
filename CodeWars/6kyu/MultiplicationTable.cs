/*
https://www.codewars.com/kata/534d2f5b5371ecf8d2000a08/csharp

6 kyu
Multiplication table

Your task, is to create NxN multiplication table, of size provided in parameter.

for example, when given size is 3:

1 2 3
2 4 6
3 6 9
for given example, the return value should be: [[1,2,3],[2,4,6],[3,6,9]]
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class KataMultiplicationTable
    {
        public static int[,] MultiplicationTable(int size)
        {
            // How do you convert result to int[,]?
            // var result = Enumerable.Range(1, size).Select(i => Enumerable.Range(1, size).Select(j => i * j));

            var table = new int[size, size];
            var n = Enumerable.Range(1, size).ToList();
            n.ForEach(i => n.ForEach(j => table[i - 1, j - 1] = i * j));
            return table;


            // var result = new int[size, size];
            // for (int i = 1; i < size + 1; i++)
            // {
            //     for (int j = 1; j < size + 1; j++)
            //     {
            //         result[i - 1, j - 1] = i * j;
            //     }
            // }
            //
            // return result;
        }
    }
}