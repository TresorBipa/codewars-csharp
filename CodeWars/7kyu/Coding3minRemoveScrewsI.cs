/*
https://www.codewars.com/kata/5710a50d336aed828100055a/csharp

7 kyu
Coding 3min : Remove screws I

John is a worker, his job is to remove screws from a machine. 
There are 2 types of screws: slotted (-) and cross (+). 
John has two screwdrivers, one for each type of screw.

The input will be a (non-empty) string of screws, e.g. : "---+++"

When John begins to work, he stands at the first screw, with the correct screwdriver in his hand, 
and another in his tool kit. He works from left to right, removing every screw. 
When necessary, he switches between the screwdriver in his hand and the one in his tool kit.

Each action takes a set amount of time:

remove one screw : 1 second
move to the next screw: 1 second
switch screwdrivers: 5 seconds
Your task is to return the total time taken to remove all the screws, in seconds.

Examples
In order to be more clear, we use ABCDEF to represent the screws. The number in brackets is the time in seconds:

screws: "---+++"
         ABCDEF

remove A (1) + move to B (1) + remove B (1) + 
move to C (1) + remove C (1) + move to D (1) +
switch screwdriver (5) + remove D (1) +
move to E (1) + remove E (1) + move to F (1) + remove F (1)

total time = 16 seconds
Another example:

screws: "-+-+-+"
         ABCDEF

remove A (1) +
move to B (1) + switch screwdriver (5) + remove B (1) +
move to C (1) + switch screwdriver (5) + remove C (1) +
move to D (1) + switch screwdriver (5) + remove D (1) +
move to E (1) + switch screwdriver (5) + remove E (1) +
move to F (1) + switch screwdriver (5) + remove F (1)

total time = 36 seconds 
Variations
Golf version

This work method may not be the fastest. For a better method, see Remove screws II

*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CodeWars
{
    public class Coding3MinRemoveScrewsI
    {
        public static int Sc(string screws)
        {
            return screws.Select((c, i) => i == 0 ? 1 : c == screws[i - 1] ? 2 : 7).Sum();

            // var totalTime = 0;
            // for (var i = 0; i < screws.Length; i++)
            //     totalTime += i == 0 ? 1 : screws[i] == screws[i - 1] ? 2 : 7;
            // return totalTime;


            // var time = 1;
            // for (var i = 1; i < screws.Length; i++, time += 2)
            // {
            //     if (screws[i - 1] != screws[i])
            //         time += 5;
            // }
            //
            // return time;
        }
    }
}