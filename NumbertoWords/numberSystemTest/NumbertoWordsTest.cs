using System;
using numberSystemTest;
using NumbertoWords;
using Xunit;

namespace numberSystemTest
{
    public class NumbertoWordsTest
    {
        [Fact]
        public void ValidNumber()
        {
            string result = numberSystem.convertToWords(99);
            string expectedResult = "ninety nine";
            Assert.Equal(expectedResult.Trim(), result.Trim());
        }

        [Fact]
        public void Zero()
        {
            string result = numberSystem.convertToWords(0);
            string expectedResult = "Zero";
            Assert.Equal(expectedResult.Trim(), result.Trim());
        }
    }
}
