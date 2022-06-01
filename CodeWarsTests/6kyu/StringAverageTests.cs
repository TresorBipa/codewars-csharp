using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class StringAverageTests
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual("four", StringAverage.AverageString("zero nine five two"));
            Assert.AreEqual("three", StringAverage.AverageString("four six two three"));
            Assert.AreEqual("three", StringAverage.AverageString("one two three four five"));
            Assert.AreEqual("four", StringAverage.AverageString("five four"));
            Assert.AreEqual("zero", StringAverage.AverageString("zero zero zero zero zero"));
            Assert.AreEqual("two", StringAverage.AverageString("one one eight one"));
            Assert.AreEqual("n/a", StringAverage.AverageString(""));
        }
    }
}