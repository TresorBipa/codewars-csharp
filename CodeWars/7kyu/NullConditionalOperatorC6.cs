/*
https://www.codewars.com/kata/55bf6b640e7ec0138e000071/csharp

7 kyu
Null-Conditional Operator (C# 6.0)

In C# 6.0 there is new operator ?. called Null-Conditional Operator. 
It's nothing revolutionary - just syntactic sugar but pretty neat one.

Use case
Imagine you have a Car, car has an Engine, 
engine has a GearBox and gear box has some property you are interested in, for example NumberOfGears. 
Now, car could be from junkyard and gear box or even engine could be missing (null).

How to determine number of gears of given car?

Instruction
Write extension method for Car called GetNumberOfGears. 
This method will return value of NumberOfGears property of gear box or -1 if gear box (or anything else) is missing.

Constrain
Find some information about ?. and ?? operators and try to write the method without any if or conditional operator ?:.

Reference
Null-conditional Operators (?.)
Null-coalescing operator (??)
Conditional operator (?:)
*/

namespace CodeWars
{
    public static class NullConditionalOperatorC6
    {
        public class Car
        {
            public Engine Engine { get; set; }
        }

        public class Engine
        {
            public GearBox GearBox { get; set; }
        }

        public class GearBox
        {
            public int NumberOfGears { get; set; }
        }

        public static int GetNumberOfGears(this Car car)
        {
            return car.Engine?.GearBox?.NumberOfGears ?? -1;
            //return car?.Engine?.GearBox?.NumberOfGears ?? -1;
        }
    }
}