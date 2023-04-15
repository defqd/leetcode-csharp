using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class FindAllNumbersDisappearedInAnArrayTests
    {
        [TestCaseSource(typeof(FindAllNumbersDisappearedInAnArrayTestSource))]
        public void FindDisappearedNumbersTest(int[] nums, List<int> expected)
        {
            var result = FindAllNumbersDisappearedInAnArray.FindDisappearedNumbers(nums);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class FindAllNumbersDisappearedInAnArrayTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new int[] { 4, 3, 2, 7, 8, 2, 3, 1 },
                new List<int> { 5, 6}
            };
            yield return new object[]
            {
                new int[] { 1, 1 },
                new List<int> { 2 }
            };
        }
    }
}