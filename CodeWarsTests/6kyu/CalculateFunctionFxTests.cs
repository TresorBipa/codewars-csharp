using System;
using CodeWars._6kyu;
using NUnit.Framework;

namespace CodeWarsTests._6kyu
{
    [TestFixture]
    public class CalculateFunctionFxTests
    {
        [Test]
        public void Test1()
        {
            Assert.IsTrue(CalculateFunctionFx.GetFunction(new[] {0, 1, 2, 3, 4})(5) == 5);
        }

        [Test]
        public void Test2()
        {
            Assert.IsTrue(CalculateFunctionFx.GetFunction(new[] {0, 3, 6, 9, 12})(10) == 30);
        }

        [Test]
        public void ShouldFail()
        {
            Assert.Throws<ArgumentException>(() => { CalculateFunctionFx.GetFunction(new[] {0, 1, 2, 3, 10})(5); });
        }
    }
}