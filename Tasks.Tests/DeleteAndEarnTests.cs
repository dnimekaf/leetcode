using Xunit;

namespace Tasks.Tests
{
    public class DeleteAndEarnTests
    {
        private readonly DeleteAndEarnSolution _solution = new();

        [Fact]
        public void Test1()
        {
            var result = _solution.DeleteAndEarn(new[] { 3, 4, 2 });
            Assert.Equal(6, result);
        }

        [Fact]
        public void Test2()
        {
            var result = _solution.DeleteAndEarn(new[] { 2, 2, 3, 3, 3, 4 });
            Assert.Equal(9, result);
        }

        [Fact]
        public void Test3()
        {
            var result = _solution.DeleteAndEarn(new[] { 8, 3, 4, 7, 6, 6, 9, 2, 5, 8, 2, 4, 9, 5, 9, 1, 5, 7, 1, 4 });
            Assert.Equal(61, result);
        }

        [Fact]
        public void Test4()
        {
            var result = _solution.DeleteAndEarn(new[]
            {
                1, 8, 5, 9, 6, 9, 4, 1, 7, 3, 3, 6, 3, 3, 8, 2, 6, 3, 2, 2, 1, 2, 9, 8, 7, 1, 1, 10, 6, 7, 3, 9, 6, 10,
                5, 4, 10, 1, 6, 7, 4, 7, 4, 1, 9, 5, 1, 5, 7, 5
            });

            Assert.Equal(138, result);
        }
    }
}