using System;
using System.Linq;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HelloNameOrWorldTests
    {
        private static readonly Random Rand = new Random();

        private static string Solution(string name = "")
        {
            return string.IsNullOrEmpty(name)
                ? "Hello, World!"
                : $"Hello, {name.ToUpper()[0] + name[1..].ToLower()}!";
        }

        [Test]
        public void BasicTest()
        {
            Assert.AreEqual("Hello, Jeff!", HelloNameOrWorld.Hello("jEFF"));
            Assert.AreEqual("Hello, Tony!", HelloNameOrWorld.Hello("tonY"));
            Assert.AreEqual("Hello, Alicia!", HelloNameOrWorld.Hello("Alicia"));
            Assert.AreEqual("Hello, World!", HelloNameOrWorld.Hello(""));
            Assert.AreEqual("Hello, John!", HelloNameOrWorld.Hello("JOHN"));
            Assert.AreEqual("Hello, Vasya!", HelloNameOrWorld.Hello("vasya"));
            Assert.AreEqual("Hello, World!", HelloNameOrWorld.Hello());
        }

        [Test]
        public void RandomTests1()
        {
            string[] names =
            {
                "James", "Christopher", "Ronald", "Mary", "Lisa", "Michelle",
                "John", "Daniel", "Anthony", "Patricia", "Nancy", "Laura",
                "Robert", "Paul", "Kevin", "Linda", "Karen", "Sarah", "Michael",
                "Mark", "Jason", "Barbara", "Betty", "Kimberly", "William", "Donald",
                "Jeff", "Elizabeth", "Helen", "Deborah", "David", "George", "Jennifer",
                "Sandra", "Richard", "Kenneth", "Maria", "Donna", "Charles", "Steven",
                "Susan", "Carol", "Joseph", "Edward", "Margaret", "Ruth", "Thomas",
                "Brian", "Dorothy", "Sharon", "Vasya", ""
            };

            for (var i = 0; i < 10000; i++)
            {
                var randomName = names[Rand.Next(0, names.Length)];
                var expected = Solution(randomName);
                var message = FailureMessage(randomName, expected);
                var actual = HelloNameOrWorld.Hello(randomName);

                Assert.AreEqual(expected, actual, message);
            }
        }

        private static string RandomName()
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return string.Concat(Enumerable.Repeat(chars, Rand.Next(2, chars.Length))
                .Select(s => s[Rand.Next(s.Length)]));
        }

        [Test]
        public void RandomTests2()
        {
            for (var i = 0; i < 100; i++)
            {
                var randomName = RandomName();
                // Console.WriteLine(randomName);
                var expected = Solution(randomName);
                var message = FailureMessage(randomName, expected);
                var actual = HelloNameOrWorld.Hello(randomName);
                Assert.AreEqual(expected, actual, message);
            }
        }

        private static string FailureMessage(string card, string value)
        {
            return $"Should return {value} with \"{card}\"";
        }
    }
}