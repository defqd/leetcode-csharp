using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class FinalValueOfVariableAfterPerformingOperationsTests
    {
        [TestCaseSource(typeof(FinalValueOfVariableAfterPerformingOperationsTestSource))]
        public void FinalValueAfterOperationsTest(string[] operations, int expected)
        {
            var result = FinalValueOfVariableAfterPerformingOperations.FinalValueAfterOperations(operations);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class FinalValueOfVariableAfterPerformingOperationsTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new string[] { "--X", "X++", "X++" },
                1
            };
            yield return new object[]
            {
                new string[] { "++X", "++X", "X++" },
                3
            };
            yield return new object[]
            {
                new string[] { "X++", "++X", "--X", "X--" },
                0
            };
        }
    }
}