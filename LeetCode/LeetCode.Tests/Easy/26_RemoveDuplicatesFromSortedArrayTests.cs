using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class RemoveDuplicatesFromSortedArrayTests
    {
        [TestCaseSource(typeof(RemoveDuplicatesFromSortedArrayTestSource))]
        public void RemoveDuplicates(int[] nums, int expected)
        {
            var result = RemoveDuplicatesFromSortedArray.RemoveDuplicates(nums);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class RemoveDuplicatesFromSortedArrayTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] 
            {
                new int [] { 1, 1, 2 },
                2
            };
            yield return new object[]
            {
                new int [] { 1, 1, 1 },
                1
            };
            yield return new object[]
            {
                new int [] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 },
                5
            };
            yield return new object[]
            {
                new int [] { 0, 1, 1 },
                2
            };
            yield return new object[]
            {
                new int [] { 0, 0, 1 },
                2
            };
            yield return new object[]
            {
                new int [] { 0, 1, 1, 2 },
                3
            };
            yield return new object[]
           {
                new int [] { 1, 2, 3},
                3
           };
        }
    }
}