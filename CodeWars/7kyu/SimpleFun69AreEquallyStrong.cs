/*
https://www.codewars.com/kata/5894017082b9fb62c50000df/csharp

7 kyu
Simple Fun #69: Are Equally Strong?

Task
Call two arms equally strong if the heaviest weights they each are able to lift are equal.

Call two people equally strong if their strongest arms are equally strong (the strongest arm can be both the right and the left), and so are their weakest arms.

Given your and your friend's arms' lifting capabilities find out if you two are equally strong.

Example
For yourLeft = 10, yourRight = 15, friendsLeft = 15 and friendsRight = 10, the output should be true;

For yourLeft = 15, yourRight = 10, friendsLeft = 15 and friendsRight = 10, the output should be true;

For yourLeft = 15, yourRight = 10, friendsLeft = 15 and friendsRight = 9, the output should be false.

Input/Output
[input] integer yourLeft

A non-negative integer representing the heaviest weight you can lift with your left arm.

[input] integer yourRight

A non-negative integer representing the heaviest weight you can lift with your right arm.

[input] integer friendsLeft

A non-negative integer representing the heaviest weight your friend can lift with his or her left arm.

[input] integer friendsRight

A non-negative integer representing the heaviest weight your friend can lift with his or her right arm.

[output] a boolean value
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class SimpleFun69AreEquallyStrong
    {
        public bool AreEquallyStrong(int YourLeft, int YourRight, int FriendsLeft, int FriendsRight)
        {
            return new HashSet<int>(new[] {YourLeft, YourRight}).SetEquals(new[] {FriendsLeft, FriendsRight});


            // return (Math.Max(YourLeft, YourRight), Math.Min(YourLeft, YourRight)) ==
            //        (Math.Max(FriendsLeft, FriendsRight), Math.Min(FriendsLeft, FriendsRight));


            // return Math.Max(YourLeft, YourRight) == Math.Max(FriendsLeft, FriendsRight) &&
            //        Math.Min(YourLeft, YourRight) == Math.Min(FriendsLeft, FriendsRight);


            // int[] yourPower = {YourLeft, YourRight};
            // int[] friendsPower = {FriendsLeft, FriendsRight};
            // return yourPower.Max() == friendsPower.Max() && yourPower.Min() == friendsPower.Min();


            // return (YourLeft < YourRight) == (FriendsLeft < FriendsRight)
            //     ? YourLeft == FriendsLeft && YourRight == FriendsRight
            //     : YourLeft == FriendsRight && YourRight == FriendsLeft;


            // int[] yourPower = {YourLeft, YourRight};
            // int[] friendsPower = {FriendsLeft, FriendsRight};
            // return yourPower.Max() == friendsPower.Max() && yourPower.Min() == friendsPower.Min();
        }
    }
}