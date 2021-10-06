/*
https://www.codewars.com/kata/grasshopper-terminal-game-move-function/csharp
https://www.codewars.com/kata/563a631f7cbbc236cf0000c2/csharp

8 kyu
Grasshopper - Terminal game move function

Terminal game move function
In this game, the hero moves from left to right. The player rolls the die and moves the number of spaces indicated by the die two times.

Create a function for the terminal game that takes the current position of the hero and the roll (1-6) and return the new position.

Example:
move(3, 6) should equal 15
*/

using System;

namespace CodeWars
{
    public class GrasshopperTerminalGameMove
    {
        public static int Move(int position, int roll)
        {
            return position + roll * 2;
        }

        //public static int Move(int position, int roll) => position + roll * 2;

        //public static int Move(int position, int roll)
        //{
        //    return (roll + roll) + position;
        //}

        //public static int Move(int position, int roll)
        //{
        //    return (roll + roll) + position;
        //}
    }
}