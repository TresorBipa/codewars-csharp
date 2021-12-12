using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun149NextDayOfWeekTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun149NextDayOfWeek();

            Assert.AreEqual(6, kata.NextDayOfWeek(4, 42));

            Assert.AreEqual(2, kata.NextDayOfWeek(6, 42));

            Assert.AreEqual(2, kata.NextDayOfWeek(7, 42));
        }
    }
}