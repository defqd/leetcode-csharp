using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class ConcatenationOfArrayTests
    {
        [TestCaseSource(typeof(ConcatenationOfArrayTestSource))]
        public void GetConcatenation(int[] nums, int[] expected)
        {
            var result = ConcatenationOfArray.GetConcatenation(nums);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class ConcatenationOfArrayTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new int[] { 1, 2, 1 },
                new int[] { 1, 2, 1, 1, 2, 1 }
            };

            yield return new object[]
            {
                new int[] { 1, 3, 2, 1 },
                new int[] { 1, 3, 2, 1, 1, 3, 2, 1 }
            };
        }
    }
}