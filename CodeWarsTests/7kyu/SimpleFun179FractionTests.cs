using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun179FractionTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun179Fraction();

            Assert.AreEqual(7, kata.Fraction(90, 120));

            Assert.AreEqual(3, kata.Fraction(2, 4));

            Assert.AreEqual(11, kata.Fraction(100, 1000));

            Assert.AreEqual(6, kata.Fraction(3, 15));

            Assert.AreEqual(157, kata.Fraction(114, 200));

            Assert.AreEqual(121, kata.Fraction(3, 118));
        }
    }
}