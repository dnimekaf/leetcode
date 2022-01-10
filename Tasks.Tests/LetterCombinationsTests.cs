using Xunit;

namespace Tasks.Tests
{
    public class LetterCombinationsTests
    {
        private readonly LetterCombinationsOfAPhoneNumber _service = new();

        [Fact]
        public void Test1()
        {
            var result = _service.LetterCombinations("23");
            Assert.Equal(9, result.Count);
            Assert.Contains("ae", result);
            Assert.Contains("af", result);
            Assert.Contains("bd", result);
            Assert.Contains("be", result);
            Assert.Contains("bf", result);
            Assert.Contains("cd", result);
            Assert.Contains("ce", result);
            Assert.Contains("cf", result);
            Assert.Contains("ad", result);
        }
        
        [Fact]
        public void Test2()
        {
            var result = _service.LetterCombinations("");
            Assert.Equal(0, result.Count);
        }
        
        [Fact]
        public void Test3()
        {
            var result = _service.LetterCombinations("2");
            Assert.Equal(3, result.Count);
            Assert.Contains("a", result);
            Assert.Contains("b", result);
            Assert.Contains("c", result);
        }

        [Fact]
        public void Test4()
        {
            var result = _service.LetterCombinations("234");
            Assert.Equal(27, result.Count);
        }
    }
}