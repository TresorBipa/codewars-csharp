using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CountDivisorsOfNumberTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(1, CountDivisorsOfNumber.Divisors(1));
            Assert.AreEqual(4, CountDivisorsOfNumber.Divisors(10));
            Assert.AreEqual(2, CountDivisorsOfNumber.Divisors(11));
            Assert.AreEqual(8, CountDivisorsOfNumber.Divisors(54));
        }
    }
}