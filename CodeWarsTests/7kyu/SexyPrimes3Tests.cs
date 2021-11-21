using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SexyPrimes3Tests
    {
        [Test]
        [TestCase(5, 11, ExpectedResult = true)]
        [TestCase(1, 11, ExpectedResult = false)]
        public static bool Sexy_Prime_Test(int x, int y)
        {
            return SexyPrimes3.SexyPrime(x, y);
        }
    }
}