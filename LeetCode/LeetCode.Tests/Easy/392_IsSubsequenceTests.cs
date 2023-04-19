using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class IsSubsequenceTests
    {
        [TestCaseSource(typeof(IsSubsequenceTestSource))]
        public void IsSubsequence(string s, string t, bool expected)
        {
            var result = IsSubsequenceSoulution.IsSubsequence(s, t);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class IsSubsequenceTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                "abc",
                "ahbgdc",
                true
            };
            yield return new object[]
            {
                "axc",
                "ahbgdc",
                false
            };
        }
    }
}