using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DivisibleIntsTests
    {
        [Test]
        public void GenericTest()
        {
            Assert.AreEqual(2, DivisibleInts.GetCount(123));
        }

        [Test]
        public void ZeroTest()
        {
            Assert.AreEqual(5, DivisibleInts.GetCount(1230));
        }

        [Test]
        public void SingleDigitTest()
        {
            Assert.AreEqual(0, DivisibleInts.GetCount(1));
        }

        [Test]
        public void LongIntegerTest()
        {
            Assert.AreEqual(25, DivisibleInts.GetCount(1111111111));
        }
    }
}