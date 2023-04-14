using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class ThirdMaximumNumberTests
    {
        [TestCaseSource(typeof(ThirdMaximumNumberTestSource))]
        public void ThirdMaximumNumberTest(int[] nums, int expected)
        {
            var result = ThirdMaximumNumber.ThirdMax(nums);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class ThirdMaximumNumberTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new int[] { 3, 2, 1 },
                1
            };
            yield return new object[]
            {
                new int[] { 1, 2 },
                2
            };
            yield return new object[]
            {
                new int[] { 2, 2, 3, 1 },
                1
            };
            yield return new object[]
            {
                new int[] { 6, 2, 2, 3, 1 },
                2
            };
            yield return new object[]
            {
                new int[] { 6, 2, 2, 3, 4 },
                3
            };
            yield return new object[]
            {
                new int[] { 5, 2, 2 },
                5
            };
            yield return new object[]
            {
                new int[] { 1, 1, 2 },
                2
            };
        }
    }
}