using System.Dynamic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataGetLengthTests
    {
        [Test]
        public void FirstTest()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            Assert.AreEqual(5, KataGetLength.GetLength(a));
        }

        [Test]
        public void SecondTest()
        {
            string a = "abcde";
            Assert.AreEqual(5, KataGetLength.GetLength(a));
        }

        // [Test]
        // public void ThirdTest()
        // {
        //     object a = new { Length = 5, Width = 2 };
        //     Assert.AreEqual(5, KataGetLength.GetLength(a));
        // }

        [Test]
        public void FourthTest()
        {
            dynamic a = new ExpandoObject();
            a.Length = 5;
            Assert.AreEqual(5, KataGetLength.GetLength(a));
        }
    }
}