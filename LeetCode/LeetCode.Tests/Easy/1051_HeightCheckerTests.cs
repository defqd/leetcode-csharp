using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class HeightCheckerTests
    {
        public void HeightCheckerTest(int[] heights, int expected)
        {
            var result = HeightCheckerSolution.HeightChecker(heights);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class HeightCheckerTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new int [] { 1, 1, 4, 2, 1, 3 },
                3
            };
            yield return new object[]
            {
                new int [] { 5, 1, 2, 3, 4 },
                5
            };
            yield return new object[]
            {
                new int [] { 1, 2, 3, 4, 5 },
                0
            };
        }
    }
}