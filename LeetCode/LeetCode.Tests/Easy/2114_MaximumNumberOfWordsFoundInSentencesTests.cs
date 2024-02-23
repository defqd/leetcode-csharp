using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    public class MaximumNumberOfWordsFoundInSentencesTests
    {
        [TestCaseSource(typeof(MaximumNumberOfWordsFoundInSentencesTestSource))]
        public void MostWordsFoundTest(string[] sentences, int expected)
        {
            var result = MaximumNumberOfWordsFoundInSentences.MostWordsFound(sentences);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class MaximumNumberOfWordsFoundInSentencesTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new string[] { "alice and bob love leetcode", "i think so too", "this is great thanks very much" },
                6
            };
            yield return new object[]
            {
                new string[] { "please wait", "continue to fight", "continue to win" },
                3
            };
        }
    }
}
