using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class CountNumberOfDaysBetweenTwoDatesTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(9,
                CountNumberOfDaysBetweenTwoDates.GetDaysAlive(2000, 1, 1, 2000, 1, 10),
                "Should return 9 with [2000.1.1] and [2000.1.10]");

            Assert.AreEqual(-9,
                CountNumberOfDaysBetweenTwoDates.GetDaysAlive(2000, 1, 10, 2000, 1, 1),
                "Should return -9 with [2000.1.10] and [2000.1.1]");

            Assert.AreEqual(0,
                CountNumberOfDaysBetweenTwoDates.GetDaysAlive(2000, 1, 1, 2000, 1, 1),
                "Should return 0 with [2000.1.1] and [2000.1.1]");

            Assert.AreEqual(5021,
                CountNumberOfDaysBetweenTwoDates.GetDaysAlive(1987, 1, 16, 2000, 10, 15),
                "Should return 5021 with [1987.1.16] and [2000.10.15]");

            Assert.AreEqual(4179,
                CountNumberOfDaysBetweenTwoDates.GetDaysAlive(2005, 10, 27, 2017, 4, 6),
                "Should return 4179 with [2005.10.27] and [2017.4.6]");

            Assert.AreEqual(3832,
                CountNumberOfDaysBetweenTwoDates.GetDaysAlive(1998, 1, 10, 2008, 7, 8),
                "Should return 3832 with [1998.1.10] and [2008.7.8]");
        }


        [Test]
        public void RandomTest1()
        {
            var startDate = new DateTime(2000, 1, 1);
            var endDate = DateTime.Now;
            var expected = Solution(startDate, endDate);
            var message = FailureMessage(startDate, endDate, expected);
            var actual = CountNumberOfDaysBetweenTwoDates.GetDaysAlive(startDate.Year, startDate.Month,
                startDate.Day, endDate.Year, endDate.Month, endDate.Day);
            // Console.WriteLine(message);
            Assert.AreEqual(expected, actual, message);
        }

        private static readonly Random Rand = new Random();

        [Test]
        public void RandomTest2()
        {
            for (var i = 0; i < 100; i++)
            {
                var startDate = RandomDateTime();
                var endDate = RandomDateTime();
                var expected = Solution(startDate, endDate);
                var message = FailureMessage(startDate, endDate, expected);
                var actual = CountNumberOfDaysBetweenTwoDates.GetDaysAlive(startDate.Year, startDate.Month,
                    startDate.Day, endDate.Year, endDate.Month, endDate.Day);

                // Console.WriteLine(message);
                Assert.AreEqual(expected, actual, message);
            }
        }

        private static string FailureMessage(DateTime d1, DateTime d2, long value)
        {
            return $"Should return {value} with [{d1.Year}.{d1.Month}.{d1.Day}] and [{d2.Year}.{d2.Month}.{d2.Day}]";
            // return $"Should return {value} with [{d1.Year}, {d1.Month}, {d1.Day}, {d2.Year}, {d2.Month}, {d2.Day}]";
        }

        private static long Solution(DateTime d1, DateTime d2)
        {
            return (long)(d2 - d1).TotalDays;
        }

        private static DateTime RandomDateTime()
        {
            int year = Rand.Next(862, 2077);
            int month = Rand.Next(1, 13);
            int day = Rand.Next(1, 29);
            return new DateTime(year, month, day);
        }
    }
}