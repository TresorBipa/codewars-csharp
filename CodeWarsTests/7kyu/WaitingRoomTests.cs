using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class WaitingRoomTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(WaitingRoom.LastChair(10), 9);
        }
    }
}