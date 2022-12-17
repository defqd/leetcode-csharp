using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class MaxConsecutiveOnesTests
    {
        [TestCaseSource(typeof(FindMaxConsecutiveOnesTestSource))]
        public void FindMaxConsecutiveOnesTest(int[] nums, int expected)
        {
            var result = MaxConsecutiveOnes.FindMaxConsecutiveOnes(nums);

            Assert.That(expected, Is.EqualTo(result));
        }

        class FindMaxConsecutiveOnesTestSource : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[] { new int[] { 1, 1, 0, 1, 1, 1 }, 3 };
                yield return new object[] { new int[] { 1, 0, 1, 1, 0, 1 }, 2 };
                yield return new object[] { new int[] { 1, 0, 0, 0, 0, 0 }, 1 };
                yield return new object[] { new int[] { 0, 0, 0, 0, 0, 1 }, 1 };
                yield return new object[] { new int[] { 0, 0, 0, 0, 0, 0 }, 0 };
            }
        }
    }
}