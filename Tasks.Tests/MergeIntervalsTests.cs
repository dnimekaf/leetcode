using Xunit;

namespace Tasks.Tests
{

    public class MergeIntervalsTests
    {
        private readonly MergeIntervals _service = new MergeIntervals();
        
        [Fact]
        public void Test1()
        {
            var result = _service.Merge(new[] { new[] { 1, 3 }, new[] { 2, 6 }, new[] { 8, 10 }, new[] { 15, 18 } });
            Assert.Equal(3, result.Length);
            Assert.Equal(1, result[0][0]);
            Assert.Equal(6, result[0][1]);
            Assert.Equal(8, result[1][0]);
            Assert.Equal(10, result[1][1]);
            Assert.Equal(15, result[2][0]);
            Assert.Equal(18, result[2][1]);
        }
        
        [Fact]
        public void Test2()
        {
            var result = _service.Merge(new[] { new[] { 1, 4 }, new[] { 4, 5 } });
            Assert.Single(result);
            Assert.Equal(1, result[0][0]);
            Assert.Equal(5, result[0][1]);
        }
    }
}