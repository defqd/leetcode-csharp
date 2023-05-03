using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class PascalTriangleTests
    {
        [TestCaseSource(typeof(PascalTriangleTestSource))]
        public void GenerateTest(int numRows, IList<IList<int>> expected)
        {
            var result = PascalTriangle.Generate(numRows);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class PascalTriangleTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                5,
                new List<IList<int>>
                {
                    new List<int> { 1 },
                    new List<int> { 1, 1 },
                    new List<int> { 1, 2, 1 },
                    new List<int> { 1, 3, 3, 1 },
                    new List<int> { 1, 4, 6, 4, 1 },
                }
            };
            yield return new object[]
            {
                1,
                new List<IList<int>>
                {
                    new List<int> { 1 }
                }
            };
        }
    }
}