/*
https://www.codewars.com/kata/58bf97cde4a5edfd4f00008d/csharp

7 kyu
Simple Fun #189: Plant Doubling

Task
Lonerz got some crazy growing plants and he wants to grow them nice and well.

Initially, the garden is completely barren.

Each morning, Lonerz can put any number of plants into the garden to grow.

And at night, each plant mutates into two plants.

Lonerz really hopes to see n plants in his garden.

Your task is to find the minimum number of plants Lonerz has to plant to get n plants one day.

Example
For n = 5, the output should be 2.

Lonerz hopes to see 5 plants. He adds 1 plant on the first morning and on the third morning there would be 4 plants in the garden. He then adds 1 more and sees 5 plants.

So, Lonerz only needs to add 2 plants to his garden.

For n = 8, the output should be 1.

Lonerz hopes to see 8 plants. Thus, he just needs to add 1 plant in the beginning and wait for it to double till 8.

Input/Output
The number of plant lonerz hopes to see in his garden.

[input] integer n

1 <= n <= 10^7

[output] an integer

The number of plants Lonerz needs to plant.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class SimpleFun189PlantDoubling
    {
        public int PlantDoubling(int n)
        {
            //return Convert.ToString(n, 2).Split('1').Length - 1;
            return Convert.ToString(n, 2).Count(c => c == '1');
        }
    }
}