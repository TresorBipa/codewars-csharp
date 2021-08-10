/*
https://www.codewars.com/kata/5a02037ac374cbab41000089/csharp

7 kyu
Help the farmer to count rabbits, chickens and cows

Farmer Bob have a big farm, where he growths chickens, rabbits and cows. 
It is very difficult to count the number of animals for each type manually, so he diceded to buy a system to do it. 
But he bought a cheap system that can count only total number of heads, 
total number of legs and total number of horns of animals on the farm. 
Help Bob to figure out how many chickens, rabbits and cows does he have?

All chickens have 2 legs, 1 head and no horns; all rabbits have 4 legs, 1 head and no horns; all cows have 4 legs, 1 head and 2 horns.

Your task is to write a function

get_animals_count(legs_number, heads_number, horns_number)
Dictionary<string, int> get_animals_count(int legs_number, int heads_number, int horns_number)
, which returns a dictionary

{"rabbits" : rabbits_count, "chickens" : chickens_count, "cows" : cows_count}
new Dictionary<string, int>(){{"rabbits", rabbits_count},{"chickens", chickens_count},{"cows", cows_count}}
Parameters legs_number, heads_number, horns_number are integer, all tests have valid input.

Example:

get_animals_count(34, 11, 6); # Should return {"rabbits" : 3, "chickens" : 5, "cows" : 3}
get_animals_count(154, 42, 10); # Should return {"rabbits" : 30, "chickens" : 7, "cows" : 5}
get_animals_count(34, 11, 6); //Should return  Dictionary<string, int>(){{"rabbits", 3},{"chickens", 5},{"cows", 3}}
get_animals_count(154, 42, 10); //Should return Dictionary<string, int>(){{"rabbits", 30},{"chickens", 7},{"cows", 5}}
*/

using System.Collections.Generic;

namespace CodeWars
{
    public class HelpFarmerToCountRabbitsChickensAndCows
    {
        public static Dictionary<string, int> get_animals_count(int legs, int heads, int horns)
        {
            // return new Dictionary<string, int>()
            // {
            //     {"rabbits", (legs - horns) / 2 - heads},
            //     {"chickens", 2 * heads - legs / 2},
            //     {"cows", horns / 2}
            // };


            int cows = horns / 2;
            int chickens = 2 * heads - (int) (0.5 * legs);
            int rabbits = heads - (cows + chickens);
            return new Dictionary<string, int>()
            {
                {"rabbits", rabbits},
                {"chickens", chickens},
                {"cows", cows},
            };

            // return new Dictionary<string, int>
            // {
            //     {"rabbits", legs_number / 2 - heads_number - horns_number / 2},
            //     {"chickens", 2 * heads_number - legs_number / 2}, {"cows", horns_number / 2}
            // };
        }
    }
}