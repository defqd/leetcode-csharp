using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [TestCaseSource(typeof(FizzBuzzTestSource))]
        public void FizzBuzzTest(int n, List<string> expected)
        {
            var result = _FizzBuzz.FizzBuzz(n);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class FizzBuzzTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 3, new List<string> { "1", "2", "Fizz" } };
            yield return new object[] { 5, new List<string> { "1", "2", "Fizz", "4", "Buzz" } };
            yield return new object[] { 15, new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" } };
        }
    }
}