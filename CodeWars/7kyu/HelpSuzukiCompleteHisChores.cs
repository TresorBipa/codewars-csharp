/*
https://www.codewars.com/kata/584dc1b7766c2bb158000226/csharp

7 kyu
Help Suzuki complete his chores!

Suzuki has a long list of chores required to keep the monastery in good order. 
Each chore can be completed independent of the others and assigned to any student. 
He needs to assign two chores to each student in a way which minimizes the total duration of the day's work. 
There will always be an even number of chores and enough students to complete them.

You will be given an array containing the estimated duration of each chore such as:

10 ≤ chores length ≤ 30

chores = [1, 5, 2, 8, 4, 9, 6, 4, 2, 2, 2, 9]

Return an array with each students work duration in ascending order such that the last element represents the total duration of the day's work. 
Each integer in the return array is the sum of each students two assigned chores.

chores = [1, 5, 2, 8, 4, 9, 6, 4, 2, 2, 2, 9]

Chore 1 = 2hrs 
Chore 2 = 9hrs

2 + 9 = 11 hours duration

return [7, 8, 8, 10, 10, 11]
Please also try the other Kata in this series..

Help Suzuki count his vegetables...
Help Suzuki pack his coal basket!
Help Suzuki purchase his Tofu!
Help Suzuki rake his garden!
Suzuki needs help lining up his students!
How many stairs will Suzuki climb in 20 years?
*/

using System.Linq;

namespace CodeWars
{
    public class HelpSuzukiCompleteHisChores
    {
        public static int[] ChoreAssignment(int[] chores)
        {
            int len = chores.Length / 2;
            chores = chores.OrderBy(i => i).ToArray();
            return chores.Take(len).Zip(chores.Skip(len).Reverse(), (x, y) => x + y).OrderBy(i => i).ToArray();
            
            
            // var arr = chores.OrderBy(x => x).ToArray();
            // return arr.Take(chores.Length / 2).Select((x, i) => x + arr[chores.Length - i - 1]).OrderBy(x => x).ToArray();


            // var len = chores.Length / 2;
            // chores = chores.OrderBy(i => i).ToArray();
            // return chores.Take(len).Zip(chores.Skip(len).Reverse(), (a, b) => a + b)
            //     .OrderBy(i => i).ToArray();


            // var oChores = chores.OrderBy(x => x).ToArray();
            // var n = chores.Length;
            // return oChores.Take(n / 2).Select((c, i) => c + oChores[n - i - 1]).OrderBy(x => x).ToArray();


            // var sorted = chores.OrderBy(i => i).ToArray();
            // var pairs = sorted.Zip(sorted.Reverse(), (i, j) => i + j).Take(sorted.Length / 2);
            // return pairs.OrderBy(i => i).ToArray();
        }
    }
}