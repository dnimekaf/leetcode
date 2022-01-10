using Xunit;

namespace Tasks.Tests
{
    public class WordSearch2Tests
    {
        private readonly WordSearch2 _service = new();

        [Fact]
        public void Test1()
        {
            var result = _service.FindWords(new[]
            {
                new[] { 'o', 'a', 'a', 'n' },
                new[] { 'e', 't', 'a', 'e' },
                new[] { 'i', 'h', 'k', 'r' },
                new[] { 'i', 'f', 'l', 'v' }
            }, new[] { "oath", "pea", "eat", "rain" });

            Assert.Equal(2, result.Count);
            Assert.Contains("eat", result);
            Assert.Contains("oath", result);
        }

        [Fact]
        public void Test2()
        {
            var result = _service.FindWords(new[]
            {
                new []{'a','b'},
                new []{'c','d'}
            }, new[] {"abcb"});

            Assert.Empty(result);
        }
        
        [Fact]
        public void Test3()
        {
            var result = _service.FindWords(new[]
            {
                new []{'a'},
            }, new[] {"a"});

            Assert.Equal(1, result.Count);
            Assert.Contains("a", result);
        }
        
        [Fact]
        public void Test4()
        {
            var result = _service.FindWords(new[]
            {
                new []{'a','b','c'},
                new []{'a','e','d'},
                new []{'a','f','g'},
            }, new[] {"abcdefg","gfedcbaaa","eaabcdgfa","befa","dgc","ade"});

            Assert.Equal(4, result.Count);
            Assert.Contains("abcdefg", result);
            Assert.Contains("befa", result);
            Assert.Contains("eaabcdgfa", result);
            Assert.Contains("gfedcbaaa", result);
        }
    }
}