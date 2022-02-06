using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun50ArrayConversionTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun50ArrayConversion();

            Assert.AreEqual(186, kata.ArrayConversion(new int[] {1, 2, 3, 4, 5, 6, 7, 8}));

            Assert.AreEqual(64, kata.ArrayConversion(new int[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}));

            Assert.AreEqual(60, kata.ArrayConversion(new int[] {3, 3, 5, 5}));
        }
    }
}