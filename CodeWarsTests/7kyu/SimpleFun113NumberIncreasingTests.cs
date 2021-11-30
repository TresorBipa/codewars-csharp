using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun113NumberIncreasingTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun113NumberIncreasing();

            Assert.AreEqual(true, kata.NumberIncreasing(1));

            Assert.AreEqual(false, kata.NumberIncreasing(2));

            Assert.AreEqual(true, kata.NumberIncreasing(3));

            Assert.AreEqual(false, kata.NumberIncreasing(4));

            Assert.AreEqual(false, kata.NumberIncreasing(5));

            Assert.AreEqual(true, kata.NumberIncreasing(6));

            Assert.AreEqual(false, kata.NumberIncreasing(100));

            Assert.AreEqual(true, kata.NumberIncreasing(101));

            Assert.AreEqual(false, kata.NumberIncreasing(12345));

            Assert.AreEqual(true, kata.NumberIncreasing(54321));
        }
    }
}