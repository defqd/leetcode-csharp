using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class LongestCommonPrefixTests
    {
        [TestCaseSource(typeof(LongestCommonPrefixTestSource))]
        public void LongestCommonPrefix(string[] strs, string expected)
        {
            var result = LongestCommonPrefixSolution.LongestCommonPrefix(strs);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class LongestCommonPrefixTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new string[] { "flower", "flow", "flight" },
                "fl"
            };
            yield return new object[]
            {
                new string[] { "reflower", "flow", "flight" },
                ""
            };
            yield return new object[]
            {
                new string[] { "dog","racecar","car" },
                ""
            };
            yield return new object[]
            {
                new string[] { "flower", "dog", "flow", "flight" },
                ""
            };
        }
    }
}