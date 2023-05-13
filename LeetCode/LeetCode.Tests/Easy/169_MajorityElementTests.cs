using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class MajorityElementTests
    {
        [TestCaseSource(typeof(MajorityElementTestSource))]
        public void MajorityElementTest(int[] nums, int expected)
        {
            var result = MajorityElementSolution.MajorityElement(nums);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class MajorityElementTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] 
            {
                new int[] { 3, 2, 3 },
                3
            };
            yield return new object[]
            {
                new int[] { 2, 2, 1, 1, 1, 2, 2 },
                2
            };
            yield return new object[]
            {
                new int[] { 0 },
                0
            };
        }
    }
}
