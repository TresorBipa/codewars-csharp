using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class ValidateCreditCardNumberTests
    {
        [Test]
        public void TestCases()
        {
            var validateCreditCardNumber = new ValidateCreditCardNumber();
            Assert.AreEqual(false, validateCreditCardNumber.validate("477 073 360"));
            Assert.AreEqual(true, validateCreditCardNumber.validate("5422 0148 5514"));
            Assert.AreEqual(true, validateCreditCardNumber.validate("8314 7046 0245"));
            Assert.AreEqual(false, validateCreditCardNumber.validate("6654 6310 43044"));
            Assert.AreEqual(true, validateCreditCardNumber.validate("0768 2757 5685 6340"));
            Assert.AreEqual(false, validateCreditCardNumber.validate("7164 6207 74042"));
            Assert.AreEqual(true, validateCreditCardNumber.validate("8383 7332 3570 8514"));
            Assert.AreEqual(true, validateCreditCardNumber.validate("481 135"));
            Assert.AreEqual(true, validateCreditCardNumber.validate("355 032 5363"));
        }
    }
}