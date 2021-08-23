/*
https://www.codewars.com/kata/564e21ba7cd824845b000097/train/csharp

7 kyu
Knight vs Bishop

Knight vs Bishop
If you are not familiar with chess game you can learn more here.

You will be provided with two object arrays. 
Each of them contains an integer and a string which represent the positions of the pieces on the chess board (e.g. [4, "C"] and [6, "D"]).

Implement a function which returns:

"Knight" if the knight can capture the bishop
"Bishop" if the bishop can capture the knight
"None" if both pieces are safe
Check the test cases and Happy coding :)
*/

using System;

namespace CodeWars
{
    public class KataKnightVsBishop
    {
        public static string KnightVsBishop(object[] knightPosition, object[] bishopPosition)
        {
            var x = Math.Abs((int) knightPosition[0] - (int) bishopPosition[0]);
            var y = Math.Abs(((string) knightPosition[1])[0] - ((string) bishopPosition[1])[0]);
            return x == y ? "Bishop" : x + y == 3 && x != 0 && y != 0 ? "Knight" : "None";
        }
    }
}