using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class LengthOfLastWordTests
    {
        [TestCaseSource(typeof(LengthOfLastWordTesSource))]
        public void LengthOfLastWord(string s, int expected) 
        {
            var result = LengthOfLastWordSolution.LengthOfLastWord(s);

            Assert.That(expected, Is.EqualTo(result));
        }
    }

    class LengthOfLastWordTesSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
            "Hello World",
            5
            };
            yield return new object[]
            {
            "   fly me   to   the moon  ",
            4
            };
            yield return new object[]
            {
            "luffy is still joyboy",
            6
            };
        }
    }
}