using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleEncryption1AlternatingSplitTests
    {
        [Test]
        public void EncryptExampleTests()
        {
            Assert.AreEqual("This is a test!", SimpleEncryption1AlternatingSplit.Encrypt("This is a test!", 0));
            Assert.AreEqual("hsi  etTi sats!", SimpleEncryption1AlternatingSplit.Encrypt("This is a test!", 1));
            Assert.AreEqual("s eT ashi tist!", SimpleEncryption1AlternatingSplit.Encrypt("This is a test!", 2));
            Assert.AreEqual(" Tah itse sits!", SimpleEncryption1AlternatingSplit.Encrypt("This is a test!", 3));
            Assert.AreEqual("This is a test!", SimpleEncryption1AlternatingSplit.Encrypt("This is a test!", 4));
            Assert.AreEqual("This is a test!", SimpleEncryption1AlternatingSplit.Encrypt("This is a test!", -1));
            Assert.AreEqual("hskt svr neetn!Ti aai eyitrsig",
                SimpleEncryption1AlternatingSplit.Encrypt("This kata is very interesting!", 1));
        }

        [Test]
        public void DecryptExampleTests()
        {
            Assert.AreEqual("This is a test!", SimpleEncryption1AlternatingSplit.Decrypt("This is a test!", 0));
            Assert.AreEqual("This is a test!", SimpleEncryption1AlternatingSplit.Decrypt("hsi  etTi sats!", 1));
            Assert.AreEqual("This is a test!", SimpleEncryption1AlternatingSplit.Decrypt("s eT ashi tist!", 2));
            Assert.AreEqual("This is a test!", SimpleEncryption1AlternatingSplit.Decrypt(" Tah itse sits!", 3));
            Assert.AreEqual("This is a test!", SimpleEncryption1AlternatingSplit.Decrypt("This is a test!", 4));
            Assert.AreEqual("This is a test!", SimpleEncryption1AlternatingSplit.Decrypt("This is a test!", -1));
            Assert.AreEqual("This kata is very interesting!",
                SimpleEncryption1AlternatingSplit.Decrypt("hskt svr neetn!Ti aai eyitrsig", 1));
        }

        [Test]
        public void EmptyTests()
        {
            Assert.AreEqual("", SimpleEncryption1AlternatingSplit.Encrypt("", 0));
            Assert.AreEqual("", SimpleEncryption1AlternatingSplit.Decrypt("", 0));
        }

        [Test]
        public void NullTests()
        {
            Assert.AreEqual(null, SimpleEncryption1AlternatingSplit.Encrypt(null, 0));
            Assert.AreEqual(null, SimpleEncryption1AlternatingSplit.Decrypt(null, 0));
        }
    }
}