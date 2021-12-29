using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class EvensTimesLastTests
    {
        [Test]
        public void EmptyArrayTest()
        {
            Assert.AreEqual(0, EvensTimesLast.EvenTimesLast(Array.Empty<int>()));
        }
    
        [Test]
        public void ArrayWithOneElementTest()
        {
            Assert.AreEqual(49, EvensTimesLast.EvenTimesLast(new[] { 7 }));
        }
    
        [Test]
        public void ArrayWithTwoElementsTest()
        {
            Assert.AreEqual(91, EvensTimesLast.EvenTimesLast(new[] { 7, 13 }));
        }
    
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(30, EvensTimesLast.EvenTimesLast(new int[] {2, 3, 4, 5}));
            Assert.AreEqual(0, EvensTimesLast.EvenTimesLast(new int[] {2, 3, 4, 5, 0}));
            Assert.AreEqual(-6, EvensTimesLast.EvenTimesLast(new int[] {2, 3, 4, -1}));
        }
    }
}