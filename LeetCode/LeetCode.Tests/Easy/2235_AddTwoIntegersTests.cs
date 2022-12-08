using LeetCode.Easy;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class AddTwoIntegersTests
    {
        [TestCase(12, 5, 17)]
        [TestCase(-10, 4, -6)]
        public void SumTest(int num1, int num2, int expected)
        {
            var result = AddTwoIntegers.Sum(num1, num2);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}