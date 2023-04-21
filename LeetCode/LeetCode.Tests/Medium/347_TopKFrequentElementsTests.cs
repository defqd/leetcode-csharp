using LeetCode.Medium;
using System.Collections;

namespace LeetCode.Tests.Medium
{
    [TestFixture]
    public class TopKFrequentElementsTests
    {
        [TestCaseSource(typeof(TopKFrequentElementsTestSource))]
        public void TopKFrequentTest(int[] nums, int k, int[] expected)
        {
            var result = TopKFrequentElements.TopKFrequent(nums, k);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class TopKFrequentElementsTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new int[] { 1, 1, 1, 2, 2, 3 },
                2,
                new int[] { 1, 2 }
            };
            yield return new object[]
            {
                new int[] { 1 },
                1,
                new int[] { 1 }
            };            
            yield return new object[]
            {
                new int[] { 1, 2 },
                2,
                new int[] { 1, 2 }
            };
        }
    }
}