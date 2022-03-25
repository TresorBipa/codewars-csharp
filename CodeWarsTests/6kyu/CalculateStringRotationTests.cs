using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class CalculateStringRotationTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(4, CalculateStringRotation.ShiftedDiff("eecoff", "coffee"));
            Assert.AreEqual(-1, CalculateStringRotation.ShiftedDiff("Moose", "moose"));
            Assert.AreEqual(2, CalculateStringRotation.ShiftedDiff("isn't", "'tisn"));
            Assert.AreEqual(0, CalculateStringRotation.ShiftedDiff("Esham", "Esham"));
            Assert.AreEqual(0, CalculateStringRotation.ShiftedDiff(" ", " "));
            Assert.AreEqual(-1, CalculateStringRotation.ShiftedDiff("hoop", "pooh"));
            Assert.AreEqual(-1, CalculateStringRotation.ShiftedDiff("  ", " "));
        }
    }
}