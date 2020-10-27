using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class NumbersWhichSumOfPowersTests
    {
        [Test]
        public static void test1()
        {
            Assert.AreEqual(new int[] { }, NumbersWhichSumOfPowers.EqSumPowDig(100, 2));
            Assert.AreEqual(new int[] {153}, NumbersWhichSumOfPowers.EqSumPowDig(200, 3));
            Assert.AreEqual(new int[] {153, 370}, NumbersWhichSumOfPowers.EqSumPowDig(370, 3));
            Assert.AreEqual(new int[] {153, 370, 371}, NumbersWhichSumOfPowers.EqSumPowDig(400, 3));
        }
    }
}