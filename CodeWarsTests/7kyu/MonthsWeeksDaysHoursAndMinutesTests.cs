using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MonthsWeeksDaysHoursAndMinutesTests
    {
        [Test]
        public void Fixed()
        {
            Assert.AreEqual("1 minute", MonthsWeeksDaysHoursAndMinutes.DisplayValue(1));
            Assert.AreEqual("1 hour 40 minutes", MonthsWeeksDaysHoursAndMinutes.DisplayValue(100));
            Assert.AreEqual("1 month 1 minute", MonthsWeeksDaysHoursAndMinutes.DisplayValue(40321));
            Assert.AreEqual("1 month 1 week 1 day 17 hours 14 minutes",
                MonthsWeeksDaysHoursAndMinutes.DisplayValue(52874));
        }
    }
}