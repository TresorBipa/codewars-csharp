using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CharacterWithLongestConsecutiveRepetitionTests
    {
        [Test]
        public void LongestAtTheBeginning()
        {
            Assert.AreEqual(new Tuple<char?, int>('a', 4),
                CharacterWithLongestConsecutiveRepetition.LongestRepetition("aaaabb"));
            Assert.AreEqual(new Tuple<char?, int>('b', 5),
                CharacterWithLongestConsecutiveRepetition.LongestRepetition("abbbbb"));
        }

        [Test]
        public void LongestAtTheEnd()
        {
            Assert.AreEqual(new Tuple<char?, int>('a', 4),
                CharacterWithLongestConsecutiveRepetition.LongestRepetition("bbbaaabaaaa"));
        }

        [Test]
        public void LongestInTheMiddle()
        {
            Assert.AreEqual(new Tuple<char?, int>('u', 3),
                CharacterWithLongestConsecutiveRepetition.LongestRepetition("cbdeuuu900"));
        }

        [Test]
        public void MultipleLongest()
        {
            Assert.AreEqual(new Tuple<char?, int>('a', 2),
                CharacterWithLongestConsecutiveRepetition.LongestRepetition("aabb"));
            Assert.AreEqual(new Tuple<char?, int>('b', 1),
                CharacterWithLongestConsecutiveRepetition.LongestRepetition("ba"));
        }

        [Test]
        public void EmptyString()
        {
            Assert.AreEqual(new Tuple<char?, int>(null, 0),
                CharacterWithLongestConsecutiveRepetition.LongestRepetition(""));
        }
    }
}