using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class MoveZeroesTests
    {
        [TestCaseSource(typeof(MoveZeroesTestSource))]
        public void MoveZeroTest(int[] nums, int[] expected)
        {
            MoveZeroes.MoveZero(nums);

            Assert.That(expected, Is.EqualTo(nums));
        }
    }

    class MoveZeroesTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new int[] { 0, 1, 0, 3, 12 },
                new int [] { 1, 3, 12, 0, 0 }
            };
            yield return new object[]
            {
                new int[] { 0 },
                new int [] { 0 }
            };
            yield return new object[]
            {
                new int[] { 1, 0, 1 },
                new int [] { 1, 1, 0 }
            };
        }
    }
}
