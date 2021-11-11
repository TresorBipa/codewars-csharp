using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataTenGreenBottlesTests
    {
        [Test]
        public void Ex()
        {
            var expected =
                "Two green bottles hanging on the wall,\n" +
                "Two green bottles hanging on the wall,\n" +
                "And if one green bottle should accidentally fall,\n" +
                "There'll be one green bottle hanging on the wall.\n" +
                "\n" +
                "One green bottle hanging on the wall,\n" +
                "One green bottle hanging on the wall,\n" +
                "If that one green bottle should accidentally fall,\n" +
                "There'll be no green bottles hanging on the wall.\n";
            Assert.AreEqual(expected, KataTenGreenBottles.TenGreenBottles(2));
        }
    }
}