using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    internal class NumberOfEmployeesWhoMetTheTargetTests
    {
        [TestCaseSource(typeof(NumberOfEmployeesWhoMetTheTargetTestSource))]
        public void NumberOfEmployeesWhoMetTargetTest(int[] hours, int target, int expected)
        {
            var result = NumberOfEmployeesWhoMetTheTarget.NumberOfEmployeesWhoMetTarget(hours, target);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class NumberOfEmployeesWhoMetTheTargetTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new int[] { 0, 1, 2, 3, 4 },
                2,
                3
            };
            yield return new object[]
            {
                new int[] { 5, 1, 4, 2, 2 },
                6,
                0
            };
        }
    }
}