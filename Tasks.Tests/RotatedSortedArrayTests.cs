using Xunit;

namespace Tasks.Tests
{
    public class RotatedSortedArrayTests
    {
        private readonly RotatedSortedArray _service = new();

        [Fact]
        public void Test0()
        {
            var result = _service.Search(new[] { 0, 1, 2, 4, 5, 6, 7, }, 0);
            Assert.Equal(0, result);
        }
        
        [Fact]
        public void Test1()
        {
            var result = _service.Search(new[] { 4, 5, 6, 7, 0, 1, 2 }, 0);
            Assert.Equal(4, result);
        }
        
        
        [Fact]
        public void Test1_1()
        {
            var result = _service.Search(new[] {  7, 0, 1, 2, 4, 5, 6 }, 0);
            Assert.Equal(1, result);
        }
        
        [Fact]
        public void Test1_2()
        {
            var result = _service.Search(new[] { 1, 2, 4, 5, 6, 7, 0 }, 0);
            Assert.Equal(6, result);
        }
        
        [Fact]
        public void Test2()
        {
            var result = _service.Search(new[] {4,5,6,7,0,1,2}, 3);
            Assert.Equal(-1, result);
        }
        
        [Fact]
        public void Test3()
        {
            var result = _service.Search(new[] { 1 }, 0);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Test4()
        {
            var result = _service.Search(new[] { 3,4,5,6,1,2 }, 2);
            Assert.Equal(5, result);
        }
        
      
    }
}