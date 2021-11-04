/*
https://www.codewars.com/kata/576d209bed916d2ea30000f7/csharp

7 kyu
Vault experience (1): Enough water for how many days?

Hello dweller,

I'm the overseer of our vault, in which we all live.

I make it short: We are out of water. The only question is when!
Here is a list of all dwellers with their respective age int[] ageOfDweller.
In our tank currently are int water liters of water.
I want to know from you: How long will rich our supplies.

Remember!
Each dweller has a different water consumption.
A dweller under 18 consumes 1 liter per day, everyone older than 50 needs 1.5 liters and the rest needs 2 liters per day.
Each dweller must get its prescribed ration of water, every day!
If not satisfied all dweller, then our days are numbered.

Good luck! I'll bet on you!


Note from Vault Technicians:
Your program returns a positive integer. The residual water is not calculated.
return -1; - If no dweller living inside of the Vault.

-
Imagine further "Vault experience":

Vault experience (1): Enough water for how many days?
Vault experience (2): Hack my terminal!
Vault experience (3): Populate the vaults
more soon ...
*/

using System.Linq;

namespace CodeWars
{
    public class VaultExperience1EnoughWaterForHowManyDays
    {
        public static int ThirstyIn(int water, int[] ageOfDweller)
        {
            return ageOfDweller.Any() ? water * 2 / ageOfDweller.Sum(i => i < 18 ? 2 : i < 50 ? 4 : 3) : -1;

            // return ageOfDweller.Any() ? water / (int) ageOfDweller.Sum(a => a < 18 ? 1 : a > 50 ? 1.5 : 2) : -1;
            // return ageOfDweller.Any() ? (int) (water / ageOfDweller.Sum(i => i < 18 ? 1d : i > 50 ? 1.5 : 2d)) : -1;
            // return ageOfDweller.Length == 0 ? -1 : water * 2 / ageOfDweller.Sum(a => a < 18 ? 2 : a < 50 ? 4 : 3);
            // return !ageOfDweller.Any() ? -1 : (int) (water / ageOfDweller.Sum(i => i < 18 ? 1.0 : i > 50 ? 1.5 : 2.0));
            // return ageOfDweller.Length == 0 ? -1 : water * 2 / ageOfDweller.Sum(a => a < 18 ? 2 : a < 50 ? 4 : 3);
            // return ageOfDweller.Any()
            //     ? (int) (water / ageOfDweller.Select(p => p < 18 ? 1 : p <= 50 ? 2 : 1.5).Sum())
            //     : -1;
        }
    }
}