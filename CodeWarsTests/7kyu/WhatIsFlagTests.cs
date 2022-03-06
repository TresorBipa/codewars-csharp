using System.Security.Cryptography;
using System.Text;
using CodeWars._7kyu;
using NUnit.Framework;

namespace CodeWarsTests._7kyu
{
    [TestFixture]
    public class WhatIsFlagTests
    {
        [Test]
        public void TheOnlyTest()
        {
            if (!IsFlag(WhatIsFlag.Flag)) Assert.Fail("That's not the flag");
            else Assert.Pass();
            bool IsFlag(string flag) => CreateMD5(flag).Equals("54EEE94FC5D5F2F0A9E3FF9D48458E6D");
        }

        private static string CreateMD5(string input)
        {
            using (var md5 = MD5.Create())
            {
                var digest = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder();
                for (int i = 0; i < digest.Length; i++)
                    sb.Append(digest[i].ToString("X2"));
                return sb.ToString();
            }
        }
    }
}