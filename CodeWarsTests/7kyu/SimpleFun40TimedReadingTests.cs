using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun40TimedReadingTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun40TimedReading();

            Assert.AreEqual(7, kata.TimedReading(4, "The Fox asked the stork, 'How is the soup?'"));

            Assert.AreEqual(0, kata.TimedReading(1, "..."));

            Assert.AreEqual(3, kata.TimedReading(3, "This play was good for us."));

            Assert.AreEqual(5, kata.TimedReading(3, "Suddenly he stopped, and glanced up at the houses"));

            Assert.AreEqual(11,
                kata.TimedReading(6, "Zebras evolved among the Old World horses within the last four million years."));

            Assert.AreEqual(6,
                kata.TimedReading(5, "Although zebra species may have overlapping ranges, they do not interbreed."));

            Assert.AreEqual(0, kata.TimedReading(1, "Oh!"));

            Assert.AreEqual(14,
                kata.TimedReading(5,
                    "Now and then, however, he is horribly thoughtless, and seems to take a real delight in giving me pain."));
        }
    }
}