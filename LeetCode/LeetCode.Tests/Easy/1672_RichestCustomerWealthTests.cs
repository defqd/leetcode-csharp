using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class RichestCustomerWealthTests
    {
        [TestCaseSource(typeof(RichestCustomerWealthTestSource))]
        public void MaximumWealthTest(int[][] accounts, int expected)
        {
            var result = RichestCustomerWealth.MaximumWealth(accounts);

            Assert.That(result, Is.EqualTo(expected));
        }

        class RichestCustomerWealthTestSource : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[] 
                { 
                    new int[][] 
                    { 
                        new int [] {1, 2, 3}, 
                        new int [] {3, 2, 1} 
                    },
                    6
                };

                yield return new object[]
                {
                    new int[][]
                    {
                        new int [] {1, 5},
                        new int [] {7, 3},
                        new int [] {3, 5}
                    },
                    10
                };

                yield return new object[]
                {
                    new int[][]
                    {
                        new int [] {2, 8, 7},
                        new int [] {7, 1, 3},
                        new int [] {1, 9, 5}
                    },
                    17
                };

                yield return new object[]
               {
                    new int[][]
                    {
                        new int [] {7, 1, 3},
                        new int [] {1, 0, 5},
                        new int [] {2, 8, 7}
                    },
                    17
               };
            }
        }
    }
}