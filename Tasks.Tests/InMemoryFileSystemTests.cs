using Xunit;

namespace Tasks.Tests
{
    public class InMemoryFileSystemTests
    {
        private readonly InMemoryFileSystem _fileSystem = new();

        [Fact]
        public void Test1()
        {
            _fileSystem.Mkdir("/a/b/c");
        }
        
        [Fact]
        public void Test2()
        {
            var result = _fileSystem.Ls("/");
            Assert.Empty(result);
        }
        
        [Fact]
        public void Test2_1()
        {
            _fileSystem.Mkdir("/a/b/c");
            var result = _fileSystem.Ls("/");
            Assert.Contains("a", result);
        }
        
        [Fact]
        public void Test2_2()
        {
            _fileSystem.Mkdir("/a/b/c");
            _fileSystem.Mkdir("/a/b/a");
            var result = _fileSystem.Ls("/a/b");
            Assert.Contains("a", result);
            Assert.Contains("c", result);
        }
        
        [Fact]
        public void Test3_1()
        {
            _fileSystem.Mkdir("/a/b/c");
            _fileSystem.AddContentToFile("/a/b/c/d", "hello");
            var result = _fileSystem.ReadContentFromFile("/a/b/c/d");
            Assert.Contains("hello", result);
        }
        
        [Fact]
        public void Test3_2()
        {
            _fileSystem.Mkdir("/m");
            _fileSystem.Mkdir("/w");
            _fileSystem.AddContentToFile("/dycete", "hello");
            var result = _fileSystem.Ls("/dycete");

            Assert.Contains("dycete", result);
            Assert.Equal(1, result.Count);
        }
        
        [Fact]
        public void Test4()
        {
            _fileSystem.Mkdir("/goowmfn");
            _fileSystem.Ls("/goowmfn");
            _fileSystem.Ls("/");
            _fileSystem.Mkdir("/z");
            _fileSystem.Ls("/");
            _fileSystem.Ls("/");
            _fileSystem.AddContentToFile("/goowmfn/c","shetopcy");
            _fileSystem.Ls("/z");
            var result =  _fileSystem.Ls("/goowmfn/c");
            _fileSystem.Ls("/goowmfn");
            Assert.Contains("c", result);
        }
    }
}