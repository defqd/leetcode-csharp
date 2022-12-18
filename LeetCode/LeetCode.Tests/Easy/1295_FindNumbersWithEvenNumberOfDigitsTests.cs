using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class FindNumbersWithEvenNumberOfDigitsTests
    {
        [TestCaseSource(typeof(FindNumbersWithEvenNumberOfDigitsTestSource))]
        public void FindNumbersTest(int[] nums, int expected)
        {
            var result = FindNumbersWithEvenNumberOfDigits.FindNumbers(nums);

            Assert.That(expected, Is.EqualTo(result));
        }
    }


    class FindNumbersWithEvenNumberOfDigitsTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new int[] { 12, 345, 2, 6, 7896 }, 2 };
            yield return new object[] { new int[] { 555, 901, 482, 1771 }, 1 };
            yield return new object[] { new int[] { 437, 315, 322, 431, 686, 264, 442 }, 0 };
        }
    }
}