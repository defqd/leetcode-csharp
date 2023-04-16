using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class ContainsDuplicateTests
    {
        [TestCaseSource(typeof(ContainsDuplicateTestSource))]
        public void ContainsDuplicateTest(int[] nums, bool expected)
        {
            var result = ContainsDuplicateSolution.ContainsDuplicate(nums);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class ContainsDuplicateTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new int[] { 1, 2, 3, 1 },
                true
            };
            yield return new object[]
            {
                new int[] { 1, 2, 3, 4 },
                false
            };
            yield return new object[]
            {
                new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 },
                true 
            };
        }
    }
}