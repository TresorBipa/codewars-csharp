﻿using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class StatisticsForAthleticAssociationTests
    {
        [Test]
        public static void BasicTest()
        {
            Assert.AreEqual("Range: 01|01|18 Average: 01|38|05 Median: 01|32|34",
                StatisticsForAthleticAssociation.stat("01|15|59, 1|47|16, 01|17|20, 1|32|34, 2|17|17"));

            Assert.AreEqual("Range: 00|31|17 Average: 02|26|18 Median: 02|22|00",
                StatisticsForAthleticAssociation.stat(
                    "02|15|59, 2|47|16, 02|17|20, 2|32|34, 2|17|17, 2|22|00, 2|31|41"));
        }
    }
}