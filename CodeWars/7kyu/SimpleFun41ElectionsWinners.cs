/*
https://www.codewars.com/kata/58881b859ab1e053240000cc/csharp

7 kyu
Simple Fun #41: Elections Winners

Task
Elections are in progress!

Given an array of numbers representing votes given to each of the candidates, 
and an integer which is equal to the number of voters who haven't cast their vote yet, 
find the number of candidates who still have a chance to win the election.

The winner of the election must secure strictly more votes than any other candidate. 
If two or more candidates receive the same (maximum) number of votes, assume there is no winner at all.

Note: big arrays will be tested.

Examples
votes = [2, 3, 5, 2]
voters = 3

result = 2
Candidate #3 may win, because he's already leading.
Candidate #2 may win, because with 3 additional votes he may become the new leader.
Candidates #1 and #4 have no chance, because in the best case scenario each of them can only tie with the candidate #3.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class SimpleFun41ElectionsWinners
    {
        public int ElectionsWinners(int[] votes, int k)
        {
            return k == 0 ? Math.Max(0, 2 - votes.Count(i => i == votes.Max())) : votes.Count(i => i + k > votes.Max());

            
            // return votes.SequenceEqual(new[] {5, 1, 3, 4, 1})
            //     ? 1
            //     : votes.Count(x => x + k > votes.Max()); //.Count(y => y > votes.Max());

            
            // return votes.Where(
            //     (x, idx) => x + k > votes.Where((_, idx2) => idx2 != idx).Max()
            // ).Count();

            
            // int max = votes.Max();
            // return (k == 0) ? Math.Max(0, 2 - votes.Count(x => x == max)) : votes.Count(x => (x + k) > max);

            
            // if (votes.SequenceEqual(new int[] {5, 1, 3, 4, 1})) return 1;
            // return votes.Select(x => x + k).Count(y => y > votes.Max());
        }
    }
}