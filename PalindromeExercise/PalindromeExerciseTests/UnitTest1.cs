using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("madam", true)]
        [InlineData("radar", true)]
        [InlineData("noon", true)]
        [InlineData("deified", true)]
        [InlineData("dad", true)]
        [InlineData("mom", true)]
        [InlineData("face", false)]
        [InlineData("track", false)]
        [InlineData("dog", false)]
        public void IsAPalindrome(string palin, bool expected)
        {
            //Arrange
            WordSmith palindrome = new WordSmith();

            //Act
          bool actual =  palindrome.IsAPalindrome(palin);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
