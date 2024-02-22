using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    public class HowManyNumbersAreSmallerThanTheCurrentNumberTests
    {
        [TestCaseSource(typeof(HowManyNumbersAreSmallerThanTheCurrentNumberTestSource))]
        public void SmallerNumbersThanCurrentTest(int[] nums, int[] expected)
        {
            var result = HowManyNumbersAreSmallerThanTheCurrentNumber.SmallerNumbersThanCurrent(nums);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class HowManyNumbersAreSmallerThanTheCurrentNumberTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new int[] { 8, 1, 2, 2, 3 },
                new int[] { 4, 0, 1, 1, 3 }
            };
            yield return new object[]
            {
                new int[] { 6, 5, 4, 8 },
                new int[] { 2, 1, 0, 3 }
            };
            yield return new object[]
            {
                new int[] { 7, 7, 7, 7 },
                new int[] { 0, 0, 0, 0 }
            };

        }
    }
}
