using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class CheckIfNAndItsDoubleExistTests
    {
        [TestCaseSource(typeof(CheckIfNAndItsDoubleExistTestSource))]
        public void CheckIfExistTest(int[] arr, bool expected)
        {
            var result = CheckIfNAndItsDoubleExist.CheckIfExist(arr);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class CheckIfNAndItsDoubleExistTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new int [] { 10, 2, 5, 3 },
                true
            };
            yield return new object[]
            {
                new int [] { 3, 1, 7, 11 },
                false
            };
            yield return new object[]
            {
                new int [] { 10, 2, 2, 2, 5, 3, 4, 3 },
                true
            };
            yield return new object[]
            {
                new int [] { 7, 1, 14, 11 },
                true
            };
            yield return new object[]
            {
                new int [] { 0, 0 },
                true
            };
        }
    }
}