using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class ValidMountainArrayTests
    {
        [TestCaseSource(typeof(ValidMountainArrayTestSource))]
        public void ValidMountainArrayTest(int[] arr, bool expected)
        {
            var result = ValidMountainArray.ValidMountainArr(arr);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class ValidMountainArrayTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new int [] { 2, 1 },
                false
            };
            yield return new object[]
            {
                new int [] { 3, 5, 5 },
                false
            };
            yield return new object[]
            {
                new int [] { 0, 3, 2, 1 },
                true
            };
            yield return new object[]
            {
                new int [] { 0, 1, 2, 1, 2 },
                false
            };
            yield return new object[]
            {
                new int [] { 1, 3, 2 },
                true
            };
            yield return new object[]
            {
                new int [] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 },
                false
            };
            yield return new object[]
            {
                new int [] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 },
                false
            };
            yield return new object[]
            {
                new int [] { 2 },
                false
            };
            yield return new object[]
            {
                new int [] { 3, 7, 6, 4, 3, 0, 1, 0 },
                false
            };
            yield return new object[]
            {
                new int [] { 0, 1, 2, 4, 2, 1 },
                true
            };
            yield return new object[]
            {
                new int [] { 6, 7, 7, 8, 6 },
                false
            };
        }
    }
}