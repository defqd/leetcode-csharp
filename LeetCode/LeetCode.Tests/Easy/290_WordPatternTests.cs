using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    public class WordPatternTests
    {
        [TestCaseSource(typeof(WordPatternTestSource))]
        public void WordPatternTest(string pattern, string s, bool expected)
        {
            var result = WordPattern.WordPatternMethod(pattern, s);

            Assert.That(result, Is.EqualTo(expected));
        }
    }

    class WordPatternTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                "abba",
                "dog cat cat dog",
                true
            };
            yield return new object[]
            {
                "abba",
                "dog cat cat fish",
                false
            };
            yield return new object[]
            {
                "aaaa",
                "dog cat cat dog",
                false
            };
        }
    }
}