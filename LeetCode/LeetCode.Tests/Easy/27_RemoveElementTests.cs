using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class RemoveElementTests
    {
        [TestCaseSource(typeof(RemoveElementTestSource))]
        public void RemoveElem(int[] nums, int val, int expected)
        {
            var result = RemoveElement.RemoveElem(nums, val);

            Assert.That(expected, Is.EqualTo(result));
        }

        class RemoveElementTestSource : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[] 
                { 
                    new int[] { 3, 2, 2, 3 }, 
                    3,
                    2
                };
                yield return new object[]
                {
                    new int[] { 0,1,2,2,3,0,4,2 },
                    2,
                    5
                };
                yield return new object[]
                {
                    new int[] { 3, 2, 2, 0 },
                    3,
                    3
                };
            }
        }
    }
}