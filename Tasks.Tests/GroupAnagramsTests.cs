using System.Collections.Generic;
using Xunit;

namespace Tasks.Tests
{
    public class GroupAnagramsTests
    {
        private readonly GroupAnagramsSolution _service = new();

        [Fact]
        public void Test1()
        {
            var result = _service.GroupAnagrams(new[] { "eat", "tea", "tan", "ate", "nat", "bat" });
            Assert.Equal(3, result.Count);
            Assert.Contains(new List<string>() { "bat" }, result);
            Assert.Contains(new List<string>() { "tan", "nat" }, result);
            Assert.Contains(new List<string>() { "eat", "tea", "ate"}, result);
        }
        
        [Fact]
        public void Test2()
        {
            var result = _service.GroupAnagrams(new[] { "" });
            Assert.Equal(1, result.Count);
            Assert.Contains(new List<string>() { "" }, result);
        }
        
        [Fact]
        public void Test3()
        {
            var result = _service.GroupAnagrams(new[] { "a" });
            Assert.Equal(1, result.Count);
            Assert.Contains(new List<string>() { "a" }, result);
        }
    }
}