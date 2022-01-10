using Xunit;

namespace Tasks.Tests
{
    public class NumberOfIslandsTests
    {
        private readonly NumberOfIslands _service = new NumberOfIslands();

        [Fact]
        public void Test1()
        {
            var result = _service.NumIslands(new[]
            {
                new [] { '1', '1', '1', '1', '0' },
                new [] { '1', '1', '0', '1', '0' },
                new [] { '1', '1', '0', '0', '0' },
                new [] { '0', '0', '0', '0', '0' }
            });
            
            Assert.Equal(1, result);
        }
        
        [Fact]
        public void Test2()
        {
            var result = _service.NumIslands(new[]
            {
                new [] { '1', '1', '0', '0', '0' },
                new [] { '1', '1', '0', '0', '0' },
                new [] { '0', '0', '1', '0', '0' },
                new [] { '0', '0', '0', '1', '1' }
            });
            
            Assert.Equal(3, result);
        }

        [Fact]
        public void Test3()
        {
            var result = _service.NumIslands(new[]
            {
                new [] { '1' },
                new [] { '1' },
               
            });
            
            Assert.Equal(1, result);
        }

        [Fact]
        public void Test4()
        {
            var result = _service.NumIslands(new[]
            {
                new [] { '1','0','1','1','1' },
                new [] { '1','0','1','0','1' },
                new [] { '1','1','1','0','1' }
            });
            
            Assert.Equal(1, result);
        }
    }
}