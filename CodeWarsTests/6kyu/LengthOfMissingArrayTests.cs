using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class LengthOfMissingArrayTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(3,
                LengthOfMissingArray.GetLengthOfMissingArray(new object[][]
                    {new object[] {1, 2}, new object[] {4, 5, 1, 1}, new object[] {1}, new object[] {5, 6, 7, 8, 9}}));
            Assert.AreEqual(2,
                LengthOfMissingArray.GetLengthOfMissingArray(new object[][]
                {
                    new object[] {5, 2, 9}, new object[] {4, 5, 1, 1}, new object[] {1}, new object[] {5, 6, 7, 8, 9}
                }));
            Assert.AreEqual(2,
                LengthOfMissingArray.GetLengthOfMissingArray(new object[][]
                    {new object[] {null}, new object[] {null, null, null}}));
            Assert.AreEqual(5,
                LengthOfMissingArray.GetLengthOfMissingArray(new object[][]
                {
                    new object[] {'a', 'a', 'a'}, new object[] {'a', 'a'}, new object[] {'a', 'a', 'a', 'a'},
                    new object[] {'a'}, new object[] {'a', 'a', 'a', 'a', 'a', 'a'}
                }));

            // not starting with length 1
            Assert.AreEqual(4,
                LengthOfMissingArray.GetLengthOfMissingArray(new object[][]
                {
                    new object[] {5, 2, 9}, new object[] {4, 5, 1, 1, 5, 6}, new object[] {1, 1},
                    new object[] {5, 6, 7, 8, 9}
                }));

            // edge cases
            Assert.AreEqual(0, LengthOfMissingArray.GetLengthOfMissingArray(new object[][] { }));
            Assert.AreEqual(0, LengthOfMissingArray.GetLengthOfMissingArray(null));

            Assert.AreEqual(0,
                LengthOfMissingArray.GetLengthOfMissingArray(new object[][]
                    {new object[] { }, new object[] {1, 2, 2}}));
            
            Assert.AreEqual(0,
                LengthOfMissingArray.GetLengthOfMissingArray(new object[][] {new object[] {1, 2, 2}, null}));
            
            Assert.AreEqual(0,
                LengthOfMissingArray.GetLengthOfMissingArray(new object[][] {null, new object[] {1, 2, 2}}));
            
            Assert.AreEqual(0,
                LengthOfMissingArray.GetLengthOfMissingArray(new object[][]
                    {new object[] {1, 2, 2}, new object[] { }}));
        }
    }
}