/*
https://www.codewars.com/kata/58029cc9af749f80e3001e34/csharp

7 kyu
New £5 notes collectors!

The new £5 notes have been recently released in the UK and they've certainly became a sensation! 
Even those of us who haven't been carrying any cash around for a while, 
having given in to the convenience of cards, suddenly like to have some of these in their purses and pockets. 
But how many of them could you get with what's left from your salary after paying all bills? 
The programme that you're about to write will count this for you!

Given a salary and the array of bills, 
calculate your disposable income for a month and return it as a number of new £5 notes you can get with that amount. 
If the money you've got (or do not!) doesn't allow you to get any £5 notes return 0.

£££ GOOD LUCK! £££
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class New5NotesCollectors
    {
        public static int GetNewNotes(int salary, int[] bills)
        {
            //return salary - bills.Sum() >= 0 ? (salary - bills.Sum()) / 5 : 0;
            
            //return Math.Max((salary - bills.Sum()) / 5, 0);

            // int amount = salary - bills.Sum();
            // return amount > 0 ? amount / 5 : 0;

            // salary -= bills.Sum();
            // return salary < 5 ? 0 : salary / 5;
            
            return (salary -= bills.Sum()) < 5 ? 0 : salary / 5;
        }
    }
}