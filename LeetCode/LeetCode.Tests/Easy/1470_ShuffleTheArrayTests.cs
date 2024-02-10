using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    public class ShuffleTheArrayTests
    {
        [TestCaseSource(typeof(ShuffleTheArrayTestSource))]
        public void ShuffleTest(int[] array, int n, int[] expected)
        {
            var result = ShuffleTheArray.Shuffle(array, n);

            Assert.That(expected, Is.EqualTo(result));

        }
        class ShuffleTheArrayTestSource : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[]
                {
                    new int[] { 2, 5, 1, 3, 4, 7 },
                    3,
                    new int[] { 2, 3, 5, 4, 1, 7 }
                };
                yield return new object[]
                {
                    new int[] { 1, 2, 3, 4, 4, 3, 2, 1 },
                    4,
                    new int[] { 1, 4, 2, 3, 3, 2, 4, 1 }
                };
                yield return new object[]
                {
                    new int[] { 1, 1, 2, 2 },
                    2,
                    new int[] { 1, 2, 1, 2 }
                };
            }
        }
    }
}