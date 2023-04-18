using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class TwoSumTests
    {
        [TestCaseSource(typeof(TwoSumTestSource))]
        public void TwoSumTest(int[] nums, int target, int[] expected)
        {
            var result = TwoSumSolution.TwoSum(nums, target);

            Assert.That(result, Is.EqualTo(expected));
        }
    }

    class TwoSumTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new int[] { 2, 7, 11, 15 },
                9,
                new int[] { 0, 1}
            };
            yield return new object[]
            {
                new int[] { 3, 2, 4 },
                6,
                new int[] { 1, 2}
            };
            yield return new object[]
            {
                new int[] { 3, 3 },
                6,
                new int[] { 0, 1}
            };
            yield return new object[]
            {
                new int[] { 2, 7, 15, 2, 2 },
                22,
                new int[] { 1, 2}
            };
            yield return new object[]
            {
                new int[] { 2, 7, 11, 15 },
                17,
                new int[] { 0, 3}
            };
            yield return new object[]
            {
                new int[] { 2, 5, 5, 11 },
                10,
                new int[] { 1, 2}
            };
        }
    }
}