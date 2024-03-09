using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    public class MaximumNumberOfBalloonsTests
    {
        [TestCaseSource(typeof(MaximumNumberOfBalloonsTestSource))]
        public void MaxNumberOfBalloonsTest(string text, int expected)
        {
            var result = MaximumNumberOfBalloons.MaxNumberOfBalloons(text);

            Assert.That(result, Is.EqualTo(expected));
        }
    }

    class MaximumNumberOfBalloonsTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                "nlaebolko",
                1
            };            
            yield return new object[]
            {
                "loonbalxballpoon",
                2
            };            
            yield return new object[]
            {
                "leetcode",
                0
            };            
            yield return new object[]
            {
                "lloo",
                0
            };
            yield return new object[]
            {
                "balons",
                0
            };
        }
    }
}
