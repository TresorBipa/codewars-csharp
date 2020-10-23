using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class NullConditionalOperatorC6Tests
    {
        private NullConditionalOperatorC6.Car _car;

        [SetUp]
        public void SetUp()
        {
            _car = new NullConditionalOperatorC6.Car
            {
                Engine = new NullConditionalOperatorC6.Engine
                {
                    GearBox = new NullConditionalOperatorC6.GearBox
                    {
                        NumberOfGears = new Random().Next(1, 100)
                    }
                }
            };
        }

        [Test]
        public void TestNumberOfGears()
        {
            Assert.AreEqual(_car.Engine.GearBox.NumberOfGears, _car.GetNumberOfGears());
        }

        [Test]
        public void TestNullGearBox()
        {
            _car.Engine.GearBox = null;
            Assert.AreEqual(-1, _car.GetNumberOfGears());
        }

        [Test]
        public void TestNullEngine()
        {
            _car.Engine = null;
            Assert.AreEqual(-1, _car.GetNumberOfGears());
        }
    }
}