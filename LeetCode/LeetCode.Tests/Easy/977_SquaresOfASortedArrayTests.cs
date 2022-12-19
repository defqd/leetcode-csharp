using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class SquaresOfASortedArrayTests
    {
        [TestCaseSource(typeof(SquaresOfASortedArrayTestSource))]
        public void SortedSquaresTest(int[] nums, int[] expected)
        {
            var result = SquaresOfASortedArray.SortedSquares(nums);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class SquaresOfASortedArrayTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new int[] { -4, -1, 0, 3, 10 }, new int[] { 0, 1, 9, 16, 100 } };
            yield return new object[] { new int[] { -7, -3, 2, 3, 11 }, new int[] { 4, 9, 9, 49, 121 } };
        }
    }
}