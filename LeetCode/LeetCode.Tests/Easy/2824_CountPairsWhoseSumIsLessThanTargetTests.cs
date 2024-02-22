using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    public class CountPairsWhoseSumIsLessThanTargetTests
    {
        [TestCaseSource(typeof(CountPairsWhoseSumIsLessThanTargetTestSource))]
        public void CountPairsTest(IList<int> nums, int target, int expected)
        {
            var result = CountPairsWhoseSumIsLessThanTarget.CountPairs(nums, target);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class CountPairsWhoseSumIsLessThanTargetTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new int[] { -1, 1, 2, 3, 1 },
                2,
                3
            };
            yield return new object[]
            {
                new int[] { -6, 2, 5, -2, -7, -1, 3 },
                -2,
                10
            };
        }
    }
}
