using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HowManyTimesDoesItContainTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(2, HowManyTimesDoesItContain.stringCounter("Hello world", "o"));
            Assert.AreEqual(4, HowManyTimesDoesItContain.stringCounter("Wait isn't it supposed to be cynical?", "i"));
            Assert.AreEqual(4,
                HowManyTimesDoesItContain.stringCounter("I'm gona be the best code warrior ever dad", "r"));
            Assert.AreEqual(1, HowManyTimesDoesItContain.stringCounter("Do you like Harry Potter?", "?"));
        }
    }
}