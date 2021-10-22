using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class WolfInSheepsClothingTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual("Oi! Sheep number 2! You are about to be eaten by a wolf!",
                WolfInSheepsClothing.WarnSheep(new[]
                    { "sheep", "sheep", "sheep", "sheep", "sheep", "wolf", "sheep", "sheep" }),
                "Incorrect answer for [\"sheep\", \"sheep\", \"sheep\", \"sheep\", \"sheep\", \"wolf\", \"sheep\", \"sheep\"]");

            Assert.AreEqual("Pls go away and stop eating my sheep",
                WolfInSheepsClothing.WarnSheep(new[] { "sheep", "sheep", "wolf" }),
                "Incorrect answer for [\"sheep\", \"sheep\", \"wolf\"");

            Assert.AreEqual("Oi! Sheep number 5! You are about to be eaten by a wolf!",
                WolfInSheepsClothing.WarnSheep(new[] { "sheep", "wolf", "sheep", "sheep", "sheep", "sheep", "sheep" }),
                "Incorrect answer for [\"sheep\", \"wolf\", \"sheep\", \"sheep\", \"sheep\", \"sheep\", \"sheep\"");

            Assert.AreEqual("Oi! Sheep number 6! You are about to be eaten by a wolf!",
                WolfInSheepsClothing.WarnSheep(new[] { "wolf", "sheep", "sheep", "sheep", "sheep", "sheep", "sheep" }),
                "Incorrect answer for [\"wolf\", \"sheep\", \"sheep\", \"sheep\", \"sheep\", \"sheep\", \"sheep\"");

            Assert.AreEqual("Oi! Sheep number 1! You are about to be eaten by a wolf!",
                WolfInSheepsClothing.WarnSheep(new[] { "sheep", "wolf", "sheep" }),
                "Incorrect answer for [\"sheep\", \"wolf\", \"sheep\"");

            Assert.AreEqual("Pls go away and stop eating my sheep", WolfInSheepsClothing.WarnSheep(new[] { "wolf" }),
                "Incorrect answer for [\"wolf\"");
        }

        private static string Solution(string[] queue)
        {
            int position = Array.FindIndex(queue.Reverse().ToArray(), x => x == "wolf");
            return position == 0
                ? "Pls go away and stop eating my sheep"
                : $"Oi! Sheep number {position}! You are about to be eaten by a wolf!";
        }

        private static readonly Random Random = new Random();

        [Test]
        public void RandomTest1()
        {
            for (var i = 0; i < 100; i++)
            {
                var queue = Enumerable.Repeat("sheep", Random.Next(1, 10)).ToArray();
                queue[Random.Next(0, queue.Length)] = "wolf";

                string expected = Solution(queue);
                string actual = WolfInSheepsClothing.WarnSheep(queue);

                string message = $"Incorrect answer for [{string.Join(", ", queue.Select(x => $"\"{x}\""))}]";
                Assert.AreEqual(expected, actual, message);
            }
        }
    }
}

