using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    public class WidestVerticalAreaBetweenTwoPointsContainingNoPointsTests
    {
        [TestCaseSource(typeof(WidestVerticalAreaBetweenTwoPointsContainingNoPointsTestSource))]
        public void MaxWidthOfVerticalAreaTest(int[][] points, int expected)
        {
            var result = WidestVerticalAreaBetweenTwoPointsContainingNoPoints.MaxWidthOfVerticalArea(points);
            Assert.That(expected, Is.EqualTo(result));
        }
    }
    class WidestVerticalAreaBetweenTwoPointsContainingNoPointsTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new int[][]
                {
                    new int[] { 8, 7 },
                    new int[] { 9, 9 },
                    new int[] { 7, 4 },
                    new int[] { 9, 7 }
                },
                1
            };
            yield return new object[]
            {
                new int[][]
                {
                    new int[] { 3, 1 },
                    new int[] { 9, 0 },
                    new int[] { 1, 0 },
                    new int[] { 1, 4 },
                    new int[] { 5, 3 },
                    new int[] { 8, 8 }
                },
                3
            };
        }
    }
}