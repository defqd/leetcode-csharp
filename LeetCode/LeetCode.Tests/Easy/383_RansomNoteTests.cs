using LeetCode.Easy;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class RansomNoteTests
    {
        [TestCase("a", "b", false)]
        [TestCase("aa", "ab", false)]
        [TestCase("aa", "aab", true)]
        public void CanConstructTest(string ransomNote, string magazine, bool expected)
        {
            var result = RansomNote.CanConstruct(ransomNote, magazine);

            Assert.That(expected, Is.EqualTo(result));
        }
    }
}