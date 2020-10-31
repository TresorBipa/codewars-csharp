/*
https://www.codewars.com/kata/54e4aa695c8a4c4cee0004d4/csharp

7 kyu
The once rollable dice

In my simple RPG, every character will be created with the object-constructor: Character.

Character balthazaar = new Character("Balthazaar", 20);
                       // Balthazaar will be his name
                       // 20 will be his opness (as Over-Poweredness)
I did the best of my haxxing magic, but it seems I've got problems:

After creating him, my poor little hero's attacks seems to miss the magic of randomness. (The first fight with that stupid rat didn't go too well...)
balthazaar.Attack() // should RETURN 20 (his opness) + a random number from 1 to 20
                    // (the function should emulate a d20 roll)
                    // sadly that doesn't seem like the case for me,
                    // even if I call the function 100 times the d20 seems to roll only once or twice
                    // (d20 is a 20 sided dice)
After defeating that rat, I want to be able to raise his "overpoweredness-factor", thus modifying his min/max attack capabilities.
balthazaar.Opness++
balthazaar.Attack() // should RETURN 21 + a random number from 1 to 20
                    // tried cheating with it to beat that rat, but it doesn't work
Please help my Hero kill that rat, and become more Op!

Also, this is my first Kata, so I'll take any advice. Have Fun!
*/

using System;

namespace CodeWars
{
    public class Character
    {
        public string Name;
        public int Opness;
        private Random _random = new Random();

        public Character(string name, int opness)
        {
            Name = name;
            Opness = opness;
        }

        public int Attack() => _random.Next(1, 21) + Opness;
    }
}