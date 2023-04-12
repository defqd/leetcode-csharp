using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class SortArrayByParityTests
    {
        [TestCaseSource(typeof(SortArrayByParityTestSource))]
        public void SortArrayByParityTest(int[] nums, int[] expected)
        {
            var result = SortArrayByParitySolution.SortArrayByParity(nums);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class SortArrayByParityTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            //yield return new object[]
            //{
            //    new int[] { 3, 1, 2, 4 },
            //    new int[] { 2, 4, 1, 3 }
            //};
            yield return new object[]
            {
                new int[] { 3, 1, 2, 4 },
                new int[] { 4, 2, 1, 3 }
            };
            yield return new object[]
            {
                new int[] { 0 },
                new int[] { 0 }
            };
        }
    }
}