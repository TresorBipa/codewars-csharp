/*
https://www.codewars.com/kata/5883a3e547abc50eb60000bd/csharp

7 kyu
Matching Plates

Mark is working in a restaurant. There are 2 types of plates: big and small ones.

The kitchen workers put all washed plates on a stack in a completly random order, no matter what is currently needed. 
Furthermore the chef is only able to take the plate on the top.

Mark is watching the employees doing their work and gets bored after a short time. 
He challenges himself trying to figure out, wether the current stack of plates will exactly fit the needs of the chef, who has a strict order of meals to cook. 
These meals require either a big plate or a small one.

You will be given an order of plates that are required for the meals and an order of plates that are currently on the stack. 
Both are stored in arrays containing either 'b' for big or 's' for small.

Will the plates match the meals?

Tip: Both arrays are not always the same size or even filled. 
If there are no more meals that would require plates, but there are still plates left, it is no problem for the chef.
*/

using System.Linq;

namespace CodeWars
{
    public class MatchingPlates
    {
        public static bool matchingPlates(char[] meals, char[] stack)
        {
            //return stack.Length >= meals.Length && meals.Select((e, i) => e == stack[i]).All(b => b == true);
            //return stack.ToString().Contains(meals.ToString()) && meals.Length <= stack.Length;
            //return meals.Zip(stack, (x, y) => x == y).Count() == meals.Length;
            //return meals.SequenceEqual(stack) || stack.Length > meals.Length;
            //return string.Concat(stack).StartsWith(string.Concat(meals));
            //return new string(stack).StartsWith(new string(meals));
            return new string(stack).Contains(new string(meals));
            //return meals.SequenceEqual(stack.Take(meals.Length));
            //return !meals.Any() || meals.SequenceEqual(stack);
            //return meals.Length <= stack.Length;
        }
    }
}