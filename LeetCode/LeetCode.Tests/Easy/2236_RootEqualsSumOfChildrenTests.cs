using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class RootEqualsSumOfChildrenTests
    {
        [TestCaseSource(typeof(RootEqualsSumOfChildrenTestSource))]
        public void CheckTreeTest(TreeNode tree, bool expected)
        {
            var result = RootEqualsSumOfChildren.CheckTree(tree);

            Assert.That(expected, Is.EqualTo(result));
        }
    }
    class RootEqualsSumOfChildrenTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new TreeNode
                {
                    val = 10,
                    left = new TreeNode { val = 6 },
                    right = new TreeNode { val = 4 }
                },
                true
            };

            yield return new object[]
            {
                new TreeNode
                {
                    val = 5,
                    left = new TreeNode { val = 3 },
                    right = new TreeNode { val = 1 }
                },
                false
            };
        }
    }
}