/*
https://www.codewars.com/kata/5751aa92f2dac7695d000fb0/csharp

7 kyu
Mythical Heads and Tails

ou're in ancient Greece and giving Philoctetes a hand in preparing a training exercise for Hercules! 
You've filled a pit with two different ferocious mythical creatures for Hercules to battle!

Orthus

Orthus

Hydra

Hydra

The formidable "Orthus" is a 2 headed dog with 1 tail. The mighty "Hydra" has 5 heads and 1 tail.

Before Hercules goes in, he asks you "How many of each beast am I up against!?".

You know the total number of heads and the total number of tails, that's the dangerous parts, right? 
But you didn't consider how many of each beast.

Task
Given the number of heads and the number of tails, work out the number of each mythical beast!

The data is given as two parameters. Your answer should be returned as an array:

 VALID ->      [24 , 15]           INVALID ->  null
If there aren't any cases for the given amount of heads and tails - return "No solutions" or null (C#).
*/

namespace CodeWars
{
    public class MythicalHeadsAndTails
    {
        public static int[] Beasts(int heads, int tails)
        {
            if ((heads - 2 * tails) % 3 > 0 || 5 * tails - heads < 0 || heads - 2 * tails < 0) return null;
            return new[] {(5 * tails - heads) / 3, (heads - 2 * tails) / 3};


            // var orthus = (5 * tails - heads) / 3;
            // var hydra = tails - orthus;
            // return 2 * orthus + 5 * hydra == heads && orthus >= 0 && hydra >= 0 ? new int[] {orthus, hydra} : null;


            // if ((heads - 2 * tails) % 3 > 0 || 5 * tails - heads < 0 || heads - 2 * tails < 0) return null;
            // return new int[] {(5 * tails - heads) / 3, (heads - 2 * tails) / 3};


            // for (int orthus = 0; orthus <= tails; orthus++)
            // {
            //     var hydra = tails - orthus;
            //     if (orthus * 2 + hydra * 5 == heads)
            //         return new[] {orthus, hydra};
            // }
            // return null;
        }
    }
}