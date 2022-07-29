using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Globalization;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class DifferenceBetweenYearsLevel1Tests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(18, DifferenceBetweenYearsLevel1.HowManyYears("1997/10/10", "2015/10/10"));
            Assert.AreEqual(25, DifferenceBetweenYearsLevel1.HowManyYears("1990/10/10", "2015/10/10"));
            Assert.AreEqual(25, DifferenceBetweenYearsLevel1.HowManyYears("2015/10/10", "1990/10/10"));
            Assert.AreEqual(23, DifferenceBetweenYearsLevel1.HowManyYears("1992/10/24", "2015/10/24"));
            Assert.AreEqual(18, DifferenceBetweenYearsLevel1.HowManyYears("2018/10/10", "2000/10/10"));
        }

        private static int Solution(string date1, string date2)
        {
            return Math.Abs(DateTime.Parse(date1).Year - DateTime.Parse(date2).Year);
        }

        private static readonly Random Rand = new Random();

        private static string RandomDateTime()
        {
            return new DateTime().AddYears(Rand.Next(1, 2100)).AddMonths(Rand.Next(1, 12)).AddDays(Rand.Next(1, 31))
                .ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);
        }

        [Test]
        public void RandomTest()
        {
            for (var i = 0; i < 200; i++)
            {
                var dt1 = RandomDateTime();
                var dt2 = RandomDateTime();
                var expected = Solution(dt1, dt2);
                var message = FailureMessage(dt1, dt2, expected);
                var actual = DifferenceBetweenYearsLevel1.HowManyYears(dt1, dt2);
                // Console.WriteLine(message);
                Assert.AreEqual(expected, actual, message);
            }
        }

        private static string FailureMessage(string dt1, string dt2, int value)
        {
            return $"Should return {value} with \"{dt1}\" and \"{dt2}\"";
        }
    }
}