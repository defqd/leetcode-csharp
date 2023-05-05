using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class IsomorphicStringsTests
    {
        [TestCaseSource(typeof(IsomorphicStringsTestSource))]
        public void IsIsomorphic(string s, string t, bool expected)
        {
            var result = IsomorphicStrings.IsIsomorphic(s, t);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class IsomorphicStringsTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] 
            {
                "egg",
                "add",
                true
            };
            yield return new object[] 
            {
                "foo",
                "bar",
                false
            };
            yield return new object[] 
            {
                "paper",
                "title",
                true
            };
            yield return new object[] 
            {
                "badc",
                "baba",
                false
            };
            yield return new object[] 
            {
                "bbbaaaba",
                "aaabbbba",
                false
            };
        }
    }
}