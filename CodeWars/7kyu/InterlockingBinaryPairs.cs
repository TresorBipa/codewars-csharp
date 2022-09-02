/*
https://www.codewars.com/kata/628e3ee2e1daf90030239e8a/csharp

7 kyu
Interlocking Binary Pairs

Task
Write a function that checks if two non-negative integers make an "interlocking binary pair".

Interlock ?
numbers can be interlocked if their binary representations have no 1's in the same place
comparisons are made by bit position, starting from right to left (see the examples below)
when representations are of different lengths, the unmatched left-most bits are ignored
Examples
a = 9, b = 4
Stacking representations shows how they can interlock. Here, no 1's share any position, so the function returns true.

 9    1001
 4     100
a = 3, b = 6
These representations do not interlock. Finding they both have a 1 in the same position, the function returns false.

 3      11
 6     110
Input
Two non-negative integers in the range 0 <= n <= 2 ** 64 - 1.

Output
Boolean true or false whether or not these integers are interlockable.

Enjoy!
Consider one of the following kata to solve next:

Crossword Puzzle! (2x2)
Four Letter Words ~ Mutations
Is Sator Square?
Playing With Toy Blocks ~ Can you build a 4x4 square?
*/


namespace CodeWars;

public static class InterlockingBinaryPairs
{
    public static bool Interlockable(ulong a, ulong b) => (a & b) == 0;
}

