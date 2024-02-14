using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    public class FindWordsContainingCharacterTests
    {
        [TestCaseSourceAttribute(typeof(FindWordsContainingCharacterTestSource))]
        public void FindWordsContainingTest(string[] words, char x, List<int> expected)
        {
            var result = FindWordsContainingCharacter.FindWordsContaining(words, x);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class FindWordsContainingCharacterTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new string[] { "leet", "code" },
                'e',
                new List<int> {0, 1}
            };
            yield return new object[]
            {
                new string[] { "abc","bcd","aaaa","cbc" },
                'a',
                new List<int> {0, 2}
            };
            yield return new object[]
            {
                new string[] { "abc","bcd","aaaa","cbc" },
                'z',
                new List<int>()
            };
        }
    }
}