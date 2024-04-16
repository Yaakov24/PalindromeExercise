using System;
using Xunit;
using PalindromeExercise;
namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("radar", true)]
        [InlineData("rotator", true)]
        // [InlineData("go hang a salami im a lasagna hog", true)] researching how to do it
        [InlineData("racecar", true)]
        [InlineData("dog", false)]
        [InlineData("refrigerator", false)]
       // [InlineData("", false)] researching how to do it
        public void IsAPalindrome(string word, bool expected)
        {
            WordSmith palindrome = new WordSmith();

            var pal = palindrome.IsAPalindrome(word);
           
            Assert.Equal(expected, pal);
        }
    }
}
