using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class OperationsWithSequenceTests
    {
        [TestCase(31, new[] {0, 2, 1, -6, -3, 3})]
        [TestCase(0, new[] {0})]
        [TestCase(5, new[] {1, 1, 1, 1, 1})]
        public void BasicTests(int expected, int[] actual)
        {
            Assert.AreEqual(expected, OperationsWithSequence.Calc(actual));
        }
    }
}