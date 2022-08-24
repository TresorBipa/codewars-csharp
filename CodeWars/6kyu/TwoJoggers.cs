/*
https://www.codewars.com/kata/5274d9d3ebc3030802000165/csharp

6 kyu
Two Joggers

Two Joggers
Description
Bob and Charles are meeting for their weekly jogging tour. 
They both start at the same spot called "Start" and they each run a different lap, which may (or may not) vary in length. 
Since they know each other for a long time already, they both run at the exact same speed.

Illustration
Example where Charles (dashed line) runs a shorter lap than Bob:

Example laps

Task
Your job is to complete the function nbrOfLaps(x, y) that, 
given the length of the laps for Bob and Charles, 
finds the number of laps that each jogger has to complete before they meet each other again, at the same time, at the start.

The function takes two arguments:

The length of Bob's lap (larger than 0)
The length of Charles' lap (larger than 0)

The function should return an array (Tuple<int, int> in C#) containing exactly two numbers:

The first number is the number of laps that Bob has to run
The second number is the number of laps that Charles has to run

Examples:

Kata.NbrOfLaps(5, 3) => new Tuple<int, int>(3, 5);
Kata.NbrOfLaps(4, 6) => new Tuple<int, int>(3, 2);
*/


using System;

namespace CodeWars._6kyu;

public static class TwoJoggers
{
    public static Tuple<int, int> NbrOfLaps(int x, int y)
    {
        int laps;
        for (laps = 1; laps * x % y != 0; laps++) ;
        return new Tuple<int, int>(laps, laps * x / y);
    }
}