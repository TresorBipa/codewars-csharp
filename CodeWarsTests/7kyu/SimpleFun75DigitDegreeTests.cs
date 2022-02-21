using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun75DigitDegreeTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun75DigitDegree();

            Assert.AreEqual(0, kata.DigitDegree(5));

            Assert.AreEqual(1, kata.DigitDegree(100));

            Assert.AreEqual(2, kata.DigitDegree(91));

            Assert.AreEqual(2, kata.DigitDegree(99));

            Assert.AreEqual(3, kata.DigitDegree(1234567));

            Assert.AreEqual(1, kata.DigitDegree(1000000000));
        }
    }
}