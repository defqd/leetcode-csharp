using LeetCode.Medium;
using System.Collections;

namespace LeetCode.Tests.Medium
{
    [TestFixture]
    public class ProductOfArrayExceptSelfTests
    {
        [TestCaseSource(typeof(ProductOfArrayExceptSelfTestSource))]
        public void ProductExceptSelfTest(int[] nums, int[] expected)
        {
            var result = ProductOfArrayExceptSelf.ProductExceptSelf(nums);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class ProductOfArrayExceptSelfTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new int[] { 1, 2, 3, 4 },
                new int[] { 24, 12, 8, 6 }
            };
            yield return new object[]
            {
                new int[] { -1, 1, 0, -3, 3 },
                new int[] { 0, 0, 9, 0, 0 }
            };
        }
    }
}