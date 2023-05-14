using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class NextGreaterElementITests
    {
        [TestCaseSource(typeof(NextGreaterElementITestSource))]
        public void NextGreaterElement(int[] nums1, int[] nums2, int[] expected)
        {
            var result = NextGreaterElementI.NextGreaterElement(nums1, nums2);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class NextGreaterElementITestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new int[] { 4, 1, 2 },
                new int[] { 1, 3, 4, 2 },
                new int[] { -1, 3, -1 }
            };
            yield return new object[]
            {
                new int[] { 2, 4 },
                new int[] { 1, 2, 3, 4 },
                new int[] { 3, -1 }
            };
        }
    }
}