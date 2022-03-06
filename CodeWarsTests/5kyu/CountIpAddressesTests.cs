using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class CountIpAddressesTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(50, CountIpAddresses.IpsBetween("10.0.0.0", "10.0.0.50"));
            Assert.AreEqual(246, CountIpAddresses.IpsBetween("20.0.0.10", "20.0.1.0"));
        }
    }
}