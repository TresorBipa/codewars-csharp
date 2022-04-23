using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MessageValidatorTests
    {
        [Test]
        public void test1()
        {
            Assert.AreEqual(true, MessageValidator.isAValidMessage("3hey5hello2hi"));
        }

        [Test]
        public void test2()
        {
            Assert.AreEqual(true, MessageValidator.isAValidMessage("4code13hellocodewars"));
        }

        [Test]
        public void test3()
        {
            Assert.AreEqual(false, MessageValidator.isAValidMessage("3hey5hello2hi5"));
        }

        [Test]
        public void test4()
        {
            Assert.AreEqual(false, MessageValidator.isAValidMessage("code4hello5"));
        }

        [Test]
        public void test5()
        {
            Assert.AreEqual(true, MessageValidator.isAValidMessage("1a2bb3ccc4dddd5eeeee"));
        }

        [Test]
        public void test6()
        {
            Assert.AreEqual(true, MessageValidator.isAValidMessage(""));
        }
    }
}