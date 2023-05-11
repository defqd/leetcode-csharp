using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class CanPlaceFlowersTests
    {
        [TestCaseSource(typeof(CanPlaceFlowersTestSource))]
        public void CanPlaceFlowersTest(int[] flowerbed, int n, bool expected)
        {
            var result = CanPlaceFlowersSolution.CanPlaceFlowers(flowerbed, n);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class CanPlaceFlowersTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new int[] { 1, 0, 0, 0, 1 },
                2,
                false
            };
            yield return new object[]
            {
                new int[] { 1, 0, 0, 0, 1 },
                1,
                true
            };
            yield return new object[]
            {
                new int[] { 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0 },
                5,
                false
            };
        }
    }
}
