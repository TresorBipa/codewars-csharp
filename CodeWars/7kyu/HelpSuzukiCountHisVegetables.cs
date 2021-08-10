/*
https://www.codewars.com/kata/56ff1667cc08cacf4b00171b/csharp

7 kyu
Help Suzuki count his vegetables....

Help Suzuki count his vegetables....

Suzuki is the master monk of his monastery so it is up to him to ensure the kitchen is operating at full capacity to feed his students and the villagers that come for lunch on a daily basis.

This week there was a problem with his deliveries and all the vegetables became mixed up. 
There are two important aspects of cooking in his kitchen, it must be done in harmony and nothing can be wasted. Since the monks are a record keeping people the first order of business is to sort the mixed up vegetables and then count them to ensure there is enough to feed all the students and villagers.

You will be given a string with the following vegetables:

"cabbage", "carrot", "celery", "cucumber", "mushroom", "onion", "pepper", "potato", "tofu", "turnip"
Return a list of tuples with the count of each vegetable in descending order. If there are any non vegetables mixed in discard them. 
If the count of two vegetables is the same sort in reverse alphabetical order (Z->A).

(119, "pepper"),
(114, "carrot"),
(113, "turnip"),
(102, "onion"),
(101, "tofu"),
(100, "cabbage"),
(93, "mushroom"),
(90, "cucumber"),
(88, "potato"),
(80, "celery")
Please also try the other Kata in this series..

Help Suzuki purchase his Tofu!
Help Suzuki pack his coal basket!
Help Suzuki rake his garden!
Suzuki needs help lining up his students!
How many stairs will Suzuki climb in 20 years?
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class HelpSuzukiCountHisVegetables
    {
        public static readonly string[] Veggies =
            {"cabbage", "carrot", "celery", "cucumber", "mushroom", "onion", "pepper", "potato", "tofu", "turnip"};


        public static List<Tuple<int, string>> CountVegetables(string s)
        {
            return s.Split()
                .GroupBy(x => x)
                .Where(x => Veggies.Contains(x.Key))
                .Select(x => (x.Count(), x.Key).ToTuple())
                .OrderByDescending(x => x.Item1)
                .ThenByDescending(x => x.Item2)
                .ToList();
        }
    }
}