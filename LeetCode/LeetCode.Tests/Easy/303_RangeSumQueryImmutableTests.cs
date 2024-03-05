using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    public class RangeSumQueryImmutableTests
    {
        [TestCaseSource(typeof(RangeSumQueryImmutableTestSource))]
        public void SumRangeTest(int[] nums, int left, int right, int expected)
        {
            var range = new RangeSumQueryImmutable(nums);

            var result = range.SumRange(left, right);

            Assert.That(result, Is.EqualTo(expected));

        }
    }

    class RangeSumQueryImmutableTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new int[] { -2, 0, 3, -5, 2, -1 },
                0, 
                2,
                1
            };
            yield return new object[]
            {
                new int[] { -2, 0, 3, -5, 2, -1 },
                2,
                5,
                -1
            };
            yield return new object[]
            {
                new int[] { -2, 0, 3, -5, 2, -1 },
                0,
                5,
                -3
            };
        }
    }
}
