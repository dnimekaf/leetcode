using Xunit;

namespace Tasks.Tests
{
    public class WordSearchTests
    {
        private readonly WordSearch _search = new();

        [Fact]
        public void Test1()
        {
            var result = _search.Exist(new[]
            {
                new[] { 'A', 'B', 'C', 'E' },
                new[] { 'S', 'F', 'C', 'S' },
                new[] { 'A', 'D', 'E', 'E' }
            }, "ABCCED");
            Assert.True(result);
        }

        [Fact]
        public void Test2()
        {
            var result = _search.Exist(new[]
            {
                new[] { 'A','B','C','E' },
                new[] { 'S','F','C','S' },
                new[] { 'A','D','E','E' }
            }, "SEE");
            Assert.True(result);
        }
        
        [Fact]
        public void Test3()
        {
            var result = _search.Exist(new[]
            {
                new[] {'A','B','C','E' },
                new[] { 'S','F','C','S' },
                new[] { 'A','D','E','E' }
            }, "ABCB");
            Assert.False(result);
        }
        
        [Fact]
        public void Test4()
        {
            var result = _search.Exist(new[]
            {
                new[] {'a'},
            }, "a");
            Assert.True(result);
        }
        
        [Fact]
        public void Test5()
        {
            var result = _search.Exist(new[]
            {
                new[] { 'a','a','a','a' },
                new[] { 'a','a','a','a' },
                new[] { 'a','a','a','a' }
            }, "aaaaaaaaaaaaa");
            Assert.False(result);
        }
        
        [Fact]
        public void Test6()
        {
            // [["A","B","C","E"],["S","F","E","S"],["A","D","E","E"]]
            // "ABCESEEEFS"
            var result = _search.Exist(new[]
            {
                new[] { 'A','B','C','E' },
                new[] { 'S','F','E','S' },
                new[] { 'A','D','E','E' }
            }, "ABCESEEEFS");
            Assert.True(result);
        }
    }
}