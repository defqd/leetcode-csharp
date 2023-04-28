using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class BuildArrayFromPermutationTests
    {
        public void BuildArray(int[] nums, int[] expected)
        {
            var result = BuildArrayFromPermutation.BuildArray(nums);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class BuildArrayFromPermutationTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new int[] { 0, 2, 1, 5, 3, 4 },
                new int[] { 0, 1, 2, 4, 5, 3 }
            };
            yield return new object[]
            {
                new int[] { 5, 0, 1, 2, 3, 4 },
                new int[] { 4, 5, 0, 1, 2, 3 }
            };
        }
    }
}