using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class DuplicateZerosTests
    {
        [TestCaseSource(typeof(DuplicateZerosTestSource))]
        public void DuplicateZerosTest(int[] arr, int[] expected)
        {
            var result = DuplicateZeros.DuplicateZeross(arr);

            Assert.That(expected, Is.EqualTo(result));
        }

        class DuplicateZerosTestSource : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[] { new int [] { 1, 0, 2, 3, 0, 4, 5, 0 }, new int [] { 1, 0, 0, 2, 3, 0, 0, 4 } };
                yield return new object[] { new int [] { 1, 2, 3 }, new int [] { 1, 2, 3 } };
                yield return new object[] { new int [] { 0, 0, 1, 2, 3, 4 }, new int [] { 0, 0, 0, 0, 1, 2 } };
            }
        }
    }
}