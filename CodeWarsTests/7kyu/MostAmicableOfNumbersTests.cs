using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MostAmicableOfNumbersTests
    {
        [Test]
        [TestCase(220, 284, ExpectedResult = true)]
        [TestCase(220, 280, ExpectedResult = false)]
        [TestCase(1184, 1210, ExpectedResult = true)]
        [TestCase(220221, 282224, ExpectedResult = false)]
        public static bool FixedTest(int num1, int num2)
        {
            return MostAmicableOfNumbers.AmicableNumbers(num1, num2);
        }
    }
}