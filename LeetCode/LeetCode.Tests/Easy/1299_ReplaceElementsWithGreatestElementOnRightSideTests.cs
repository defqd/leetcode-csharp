using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class ReplaceElementsWithGreatestElementOnRightSideTests
    {
        [TestCaseSource(typeof(ReplaceElementsWithGreatestElementOnRightSideTestSource))]
        public void ReplaceElementsTest(int[] arr, int[] expected)
        {
            var result = ReplaceElementsWithGreatestElementOnRightSide.ReplaceElements(arr);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class ReplaceElementsWithGreatestElementOnRightSideTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new int [] { 17, 18, 5, 4, 6, 1 },
                new int [] { 18, 6, 6, 6, 1, -1 }
            };

            yield return new object[]
            {
                new int [] { 1, 2, 3, 4, 5, 6 },
                new int [] { 6, 6, 6, 6, 6, -1 }
            };

            yield return new object[]
            {
                new int [] { 1, 1, 1, 1, 1, 1 },
                new int [] { 1, 1, 1, 1, 1, -1 }
            }; 

            yield return new object[]
            {
                new int [] { 20 },
                new int [] { -1 }
            };
        }
    }
}