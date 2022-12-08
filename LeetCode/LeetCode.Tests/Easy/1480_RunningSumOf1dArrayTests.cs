using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class RunningSumOf1dArrayTests
    {
        [TestCaseSource(typeof(RunningSumOf1dArrayTestSource))]
        public void RunningSumTest(int[] nums, int[] expected)
        {
            var result = RunningSumOf1dArray.RunningSum(nums);

            Assert.That(result, Is.EqualTo(expected));
        }
    }

    class RunningSumOf1dArrayTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new int[] { 1, 2, 3, 4 }, new int[] { 1, 3, 6, 10 } };
            yield return new object[] { new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 2, 3, 4, 5 } };
            yield return new object[] { new int[] { 3, 1, 2, 10, 1 }, new int[] { 3, 4, 6, 16, 17 } };
        }
    }
}