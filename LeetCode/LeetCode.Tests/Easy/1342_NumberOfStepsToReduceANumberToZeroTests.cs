using LeetCode.Easy;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class NumberOfStepsToReduceANumberToZeroTests
    {
        [TestCase(14, 6)]
        [TestCase(8, 4)]
        [TestCase(123, 12)]
        public void NumberOfStepsTest(int num, int expected)
        {
            var result = NumberOfStepsToReduceANumberToZero.NumberOfSteps(num);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}