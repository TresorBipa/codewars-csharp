using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun106IsThueMorseTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun106IsThueMorse();
            Assert.AreEqual(true, kata.IsThueMorse(new int[] {0, 1, 1, 0, 1}));
            Assert.AreEqual(true, kata.IsThueMorse(new int[] {0}));
            Assert.AreEqual(false, kata.IsThueMorse(new int[] {1}));
            Assert.AreEqual(false, kata.IsThueMorse(new int[] {0, 1, 0, 0}));
        }
    }
}