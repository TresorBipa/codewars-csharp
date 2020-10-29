/*
https://www.codewars.com/kata/57ed4cef7b45ef8774000014/csharp

7 kyu
The Office II - Boredom Score


Every now and then people in the office moves teams or departments. Depending what people are doing with their time they can become more or less boring. Time to assess the current team.

You will be provided with an object(staff) containing the staff names as keys, and the department they work in as values.

Each department has a different boredom assessment score, as follows:

accounts = 1
finance = 2
canteen = 10
regulation = 3
trading = 6
change = 6
IS = 8
retail = 5
cleaning = 4
pissing about = 25

Depending on the cumulative score of the team, return the appropriate sentiment:

<=80: 'kill me now'
< 100 & > 80: 'i can handle this'
100 or over: 'party time!!'

The Office I - Outed
The Office III - Broken Photocopier
The Office IV - Find a Meeting Room
The Office V - Find a Chair
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class OfficeIIBoredomScore
    {
        public static string Boredom(Dictionary<string, string> staff)
        {
            var score = staff.Sum(x => x.Value switch
            {
                "accounts" => 1,
                "finance" => 2,
                "canteen" => 10,
                "regulation" => 3,
                "trading" => 6,
                "change" => 6,
                "IS" => 8,
                "retail" => 5,
                "cleaning" => 4,
                "pissing about" => 25,
                _ => 0
            });

            return score >= 100 ? "party time!!" : score <= 80 ? "kill me now" : "i can handle this";
            // return score <= 80 ? "kill me now" : score <= 100 ? "i can handle this" : "party time!!";
        }
    }
}