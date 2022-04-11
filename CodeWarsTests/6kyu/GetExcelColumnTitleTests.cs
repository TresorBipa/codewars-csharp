using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GetExcelColumnTitleTests
    {
        [Test]
        public void ExamplesInDescriptionTest()
        {
            Assert.AreEqual("A", GetExcelColumnTitle.GetColumnTitle(1));
            Assert.AreEqual("Z", GetExcelColumnTitle.GetColumnTitle(26));
            Assert.AreEqual("AZ", GetExcelColumnTitle.GetColumnTitle(52));
            Assert.AreEqual("BA", GetExcelColumnTitle.GetColumnTitle(53));
            Assert.AreEqual("ZZ", GetExcelColumnTitle.GetColumnTitle(702));
            Assert.AreEqual("AYK", GetExcelColumnTitle.GetColumnTitle(1337));
            Assert.AreEqual("XPEH", GetExcelColumnTitle.GetColumnTitle(432778));
        }

        [Test]
        public void zeroInputShouldThrowException()
        {
            Assert.Throws<Exception>(() => GetExcelColumnTitle.GetColumnTitle(0));
        }
    }
}