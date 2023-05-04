using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class UniqueEmailAddressesTests
    {
        [TestCaseSource(typeof(UniqueEmailAddressesTestSource))]
        public void NumUniqueEmails(string[] emails, int expected)
        {
            var result = UniqueEmailAddresses.NumUniqueEmails(emails);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class UniqueEmailAddressesTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new string[] { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" },
                2
            };
            yield return new object[]
            {
                new string[] { "a@leetcode.com", "b@leetcode.com", "c@leetcode.com" },
                3
            };
        }
    }
}