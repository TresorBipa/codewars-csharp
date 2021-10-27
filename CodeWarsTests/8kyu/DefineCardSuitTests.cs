using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public partial class DefineCardSuitTests
    {
        private static readonly string[] Deck =
        {
            "2♣", "3♣", "4♣", "5♣", "6♣", "7♣", "8♣", "9♣", "10♣", "J♣", "Q♣", "K♣", "A♣",
            "2♦", "3♦", "4♦", "5♦", "6♦", "7♦", "8♦", "9♦", "10♦", "J♦", "Q♦", "K♦", "A♦",
            "2♥", "3♥", "4♥", "5♥", "6♥", "7♥", "8♥", "9♥", "10♥", "J♥", "Q♥", "K♥", "A♥",
            "2♠", "3♠", "4♠", "5♠", "6♠", "7♠", "8♠", "9♠", "10♠", "J♠", "Q♠", "K♠", "A♠"
        };

        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("clubs", DefineCardSuit.DefineSuit("3♣"), "Should return clubs with \"3♣\"");
            Assert.AreEqual("spades", DefineCardSuit.DefineSuit("Q♠"), "Should return clubs with \"Q♠\"");
            Assert.AreEqual("diamonds", DefineCardSuit.DefineSuit("9♦"), "Should return clubs with \"9♦\"");
            Assert.AreEqual("hearts", DefineCardSuit.DefineSuit("J♥"), "Should return clubs with \"J♥\"");
        }

        [Test]
        public void FixedTest()
        {
            foreach (var card in Deck)
            {
                var expected = Solution(card);
                var message = FailureMessage(card, expected);
                var actual = DefineCardSuit.DefineSuit(card);

                Assert.AreEqual(expected, actual, message);
            }
        }

        private static string Solution(string card)
        {
            return card.Last() switch
            {
                '♣' => "clubs",
                '♦' => "diamonds",
                '♥' => "hearts",
                '♠' => "spades",
                _ => throw new ArgumentException()
            };

            // return card.Last() switch
            // {
            //     '♣' => "clubs",
            //     '♦' => "diamonds",
            //     '♥' => "hearts",
            //     _ => "spades"
            // };
        }

        private static readonly Random Random = new Random();

        private static string RandomCard()
        {
            var card = Deck[Random.Next(Deck.Length)];
            return card;
        }

        private static string FailureMessage(string card, string value)
        {
            return $"Should return {value} with \"{card}\"";
        }

        [Test]
        public void RandomTest()
        {
            for (var i = 0; i < 100; i++)
            {
                var card = RandomCard();
                var expected = Solution(card);
                var message = FailureMessage(card, expected);
                var actual = DefineCardSuit.DefineSuit(card);
                // Console.WriteLine(message);
                Assert.AreEqual(expected, actual, message);
            }
        }
    }
}


