using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class FindPivotIndexTests
    {
        [TestCaseSource(typeof(FindPivotIndexTestSource))]
        public void PivotIndex(int[] nums, int expected) 
        {
            var result = FindPivotIndex.PivotIndex(nums);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class FindPivotIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] 
            {
                new int[] { 1, 7, 3, 6, 5, 6 },
                3
            };
            yield return new object[]
            {
                new int[] { 1, 2, 3 },
                -1
            };
            yield return new object[]
            {
                new int[] { 2, 1, -1 },
                0
            };

        }
    }
}