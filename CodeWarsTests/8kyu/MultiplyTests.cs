using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataMultiplyTests
    {
        [Test]
        public void ShouldMultiple()
        {
            Assert.AreEqual(2, KataMultiply.multiply(2, 1));
            Assert.AreEqual(8, KataMultiply.multiply(2, 4));
        }
    }
}