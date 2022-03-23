using CodeWars;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWarsTests
{
    [TestFixture]
    public class ComGovOrgFirstTests
    {
        [Test]
        public void SimpleTests()
        {
            var source = new[]
            {
                "http://www.google.en/?x=jsdfkj",
                "http://www.google.de/?x=jsdfkj",
                "http://www.google.com/?x=jsdfkj",
                "http://www.google.com/?x=jsdfkj",
                "http://www.google.org/?x=jsdfkj",
                "http://www.google.gov/?x=jsdfkj",
            };
            var result = source.OrderByDomain();

            Assert.IsTrue(SortingTaskUtils.AreDomainsEquals(result, source));

            //should be sorted  to
            //"http://www.google.com/?x=jsdfkj",
            //"http://www.google.com/?x=jsdfkj",
            //"http://www.google.gov/?x=jsdfkj",
            //"http://www.google.org/?x=jsdfkj",
            //"http://www.google.de/?x=jsdfkj",
            //"http://www.google.en/?x=jsdfkj",
        }

        [Test]
        public void RandomTests()
        {
            for (var i = 0; i < 10; i++)
            {
                var source = SortingTaskUtils.GenerateUris();
                var result = source.OrderByDomain();
                Assert.IsTrue(SortingTaskUtils.AreDomainsEquals(result, source));
            }
        }
    }

    public static class SortingTaskUtils
    {
        private static IEnumerable<string> OrderDomains(this IEnumerable<string> source)
        {
            return source.Select(x => Regex.Match(new Uri(x).Host, @"\.[^.]*$").Value.TrimStart('.'))
                .OrderBy(x => x, new DomainComparer());
        }

        public static bool AreDomainsEquals(IEnumerable<string> result, IEnumerable<string> source)
        {
            IEnumerable<string> resultDomains;
            try
            {
                resultDomains = result.Select(x =>
                    Regex.Match(new Uri(x).Host, @"\.[^.]*$")
                        .Value.TrimStart('.'));
            }
            catch (Exception)
            {
                throw new Exception("Uri's in result were changed");
            }

            return resultDomains.SequenceEqual(source.OrderDomains());
        }

        public static IList<string> GenerateUris()
        {
            string[] domains = {"com", "org", "gov", "en", "us", "de", "tv"};
            var rnd = new Random();

            return Enumerable.Range(0, rnd.Next(50))
                .Select(i => $"http://{Guid.NewGuid()}.{domains[rnd.Next(7)]}/{Guid.NewGuid()}")
                .ToList();
        }

        private class DomainComparer : IComparer<string>
        {
            private string[] _main = {"com", "org", "gov"};

            public int Compare(string x, string y)
            {
                if (_main.Contains(x) && _main.Contains(y))
                    return string.Compare(x, y);
                if (_main.Contains(x))
                    return -1;
                if (_main.Contains(y))
                    return 1;
                return string.Compare(x, y);
            }
        }
    }
}