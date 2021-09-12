using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BoxlinesTests
    {
        private static void Act(ushort x, ushort y, ushort z, ulong expected)
        {
            var msg = $"Invalid answer for x: {x}, y: {y}, z: {z}";
            var actual = Boxlines.F(x, y, z);
            Assert.AreEqual(expected, actual, msg);
        }

        [TestCase(2, 1, 1, 20UL)]
        [TestCase(1, 2, 3, 46UL)]
        [TestCase(2, 2, 2, 54UL)]
        public void SampleTests(int x, int y, int z, ulong expected)
        {
            Act((ushort) x, (ushort) y, (ushort) z, expected);
        }
    }
}