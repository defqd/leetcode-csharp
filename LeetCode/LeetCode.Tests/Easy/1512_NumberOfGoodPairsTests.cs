using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class NumberOfGoodPairsTests
    {
        [TestCaseSource(typeof(NumberOfGoodPairsTestSource))]
        public void NumIdenticalPairsTest(int[] nums, int expected)
        {
            var result = NumberOfGoodPairsSolution.NumIdenticalPairs(nums);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class NumberOfGoodPairsTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new int[] { 1, 2, 3, 1, 1, 3 },
                4
            };
            yield return new object[]
            {
                new int[] { 1, 1, 1, 1 },
                6
            };
            yield return new object[]
            {
                new int[] { 1, 2, 3 },
                0
            };
        }
    }
}