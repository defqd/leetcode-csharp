using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    public class SumOfValuesAtIndicesWithKSetBitsTests
    {
        [TestCaseSource(typeof(SumOfValuesAtIndicesWithKSetBitsTestSource))]
        public void SumIndicesWithKSetBitsTest(IList<int> nums, int k, int expected)
        {
            var result = SumOfValuesAtIndicesWithKSetBits.SumIndicesWithKSetBits(nums, k);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class SumOfValuesAtIndicesWithKSetBitsTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new List<int> { 5, 10, 1, 5, 2 },
                1,
                13
            };
            yield return new object[]
            {
                new List<int> { 4, 3, 2, 1 },
                2,
                1
            };
        }
    }
}
