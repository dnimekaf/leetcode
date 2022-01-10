using Xunit;

namespace Tasks.Tests
{
    public class MinCostClimbingStairsSolutionTests
    {
        private readonly MinCostClimbingStairsSolution _solution = new();
        
        [Fact]
        public void Test1()
        {
            var result = _solution.MinCostClimbingStairs(new[] { 10, 15, 20 });
            Assert.Equal(15, result);
        }

        [Fact]
        public void Test2()
        {
            var result = _solution.MinCostClimbingStairs(new[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 });
            Assert.Equal(6, result);
        }

        [Fact]
        public void Tribonacci1()
        {
            _solution.Tribonacci(0);
        }
    }
}