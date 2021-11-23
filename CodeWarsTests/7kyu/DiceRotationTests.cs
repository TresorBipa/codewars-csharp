using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class DiceRotationTests
    {
        [Test]
        public void BasicTesting()
        {
            Assert.AreEqual(2, DiceRotation.Rotations(new int[] { 1, 1, 6 }));
            Assert.AreEqual(2, DiceRotation.Rotations(new int[] { 1, 2, 3 }));
            Assert.AreEqual(0, DiceRotation.Rotations(new int[] { 3, 3, 3 }));
            Assert.AreEqual(3, DiceRotation.Rotations(new int[] { 1, 6, 2, 3 }));
        }
    }
}