using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class OnlyOneGiftPerChildTests
    {
        [Test]
        public void BasicText()
        {
            Assert.DoesNotThrow(delegate { OnlyOneGiftPerChild.HandOutGift("Peter"); },
                "'Peter' must not throw an error!");
            Assert.DoesNotThrow(delegate { OnlyOneGiftPerChild.HandOutGift("Alison"); },
                "'Alison' must not throw an error!");
            Assert.DoesNotThrow(delegate { OnlyOneGiftPerChild.HandOutGift("John"); },
                "'John' must not throw an error!");
            Assert.DoesNotThrow(delegate { OnlyOneGiftPerChild.HandOutGift("Maria"); },
                "'Maria' must not throw an error!");

            Assert.Throws(typeof(ArgumentException), delegate { OnlyOneGiftPerChild.HandOutGift("Peter"); },
                "'Peter' must throw an error!");
        }
    }
}