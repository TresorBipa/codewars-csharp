using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ReverseOrRotateTests
    {
        private static void testing(string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void test1()
        {
            Console.WriteLine("Testing RevRot");
            testing(ReverseOrRotate.RevRot("1234", 0), "");
            testing(ReverseOrRotate.RevRot("", 0), "");
            testing(ReverseOrRotate.RevRot("1234", 5), "");
            String s = "733049910872815764";
            testing(ReverseOrRotate.RevRot(s, 5), "330479108928157");
        }
    }
}