using LeetCode.Easy;
using System.Collections;

namespace LeetCode.Tests.Easy
{
    [TestFixture]
    public class ValidAnagramTests
    {
        [TestCaseSource(typeof(ValidAnagramTestSource))]
        public void IsAnagram(string s, string t, bool expected)
        {
            var result = ValidAnagram.IsAnagram(s, t);

            Assert.That(result, Is.EqualTo(expected));
        }
    }

    class ValidAnagramTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                "anagram",
                "nagaram",
                true
            };            
            yield return new object[]
            {
                "rat",
                "car",
                false
            };            
            yield return new object[]
            {
                "ana",
                "na",
                false
            };            
            yield return new object[]
            {
                "ana",
                "ana",
                true
            };
        }
    }
}