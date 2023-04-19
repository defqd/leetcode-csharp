using LeetCode.Medium;
using System.Collections;

namespace LeetCode.Tests.Medium
{
    [TestFixture]
    public class GroupAnagramsTests
    {
        [TestCaseSource(typeof(GroupAnagramsTestSource))]
        public void GroupAnagramsTest(string[] strs, IList<IList<string>> expected)
        {
            var result = GroupAnagramsSolution.GroupAnagrams(strs);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class GroupAnagramsTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new string[] { "eat", "tea", "tan", "ate", "nat", "bat" },
                new List<IList<string>>
                {
                    new List<string> { "eat","tea","ate" },
                    new List<string> { "tan", "nat" },
                    new List<string> { "bat" }
                }
            };
            yield return new object[]
            {
                new string[] { "a" },
                new List<IList<string>>
                {
                    new List<string> { "a" }
                }
            };
            yield return new object[]
            {
                new string[] { },
                new List<IList<string>> { }
            };
        }
    }
}
