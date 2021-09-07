/*
https://www.codewars.com/kata/54466996990c921f90000d61/csharp

7 kyu
Monotone travel

Story
Peter lives on a hill, and he always moans about the way to his home. "It's always just up. I never get a rest". 
But you're pretty sure that at least at one point Peter's altitude doesn't rise, but fall. 
To get him, you use a nefarious plan: you attach an altimeter to his backpack and you read the data from his way back at the next day.

Task
You're given a list of compareable elements:

heights = new int[0 ... 100]
Your job is to check whether for any x all successors are greater or equal to x.

Kata.IsMonotone(new int[] {1,2,3}) => true
Kata.IsMonotone(new int[] {1,1,2}) => true
Kata.IsMonotone(new int[] {1})     => true
Kata.IsMonotone(new int[] {3,2,1}) => false
Kata.IsMonotone(new int[] {3,2,2}) => false
If the list is empty, Peter has probably removed your altimeter, so we cannot prove him wrong and he's still right:

Kata.IsMonotone(new int[] {}) => true
Such a sequence is also called monotone or monotonic sequence, hence the name isMonotone.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class MonotoneTravel
    {
        public static bool IsMonotone(int[] arr)
        {
            //return arr.Skip(1).Select((x, i) => x >= arr[i]).All(x => x);
            //return !arr.Where((x, i) => i != 0 && arr[i - 1] > x).Any();
            //return arr.SequenceEqual(arr.OrderBy(i => i));
            return arr.OrderBy(i => i).SequenceEqual(arr);
        }
    }
}