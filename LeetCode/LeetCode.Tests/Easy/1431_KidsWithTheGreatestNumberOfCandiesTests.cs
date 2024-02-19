using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    public class KidsWithTheGreatestNumberOfCandiesTests
    {
        [TestCaseSource(typeof(KidsWithTheGreatestNumberOfCandiesTestSource))]
        public void KidsWithCandiesTest(int[] candies, int extraCandies, List<bool> expected)
        {
            var result = KidsWithTheGreatestNumberOfCandies.KidsWithCandies(candies, extraCandies);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class KidsWithTheGreatestNumberOfCandiesTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new int[] { 2, 3, 5, 1, 3 },
                3,
                new List<bool> { true, true, true, false, true }
            };
            yield return new object[]
            {
                new int[] { 4, 2, 1, 1, 2 },
                1,
                new List<bool> { true, false, false, false, false }
            };
            yield return new object[]
            {
                new int[] { 12, 1, 12 },
                10,
                new List<bool> { true, false, true }
            };
        }
    }
}