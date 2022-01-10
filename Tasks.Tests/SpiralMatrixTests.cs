using System.Collections.Generic;
using Xunit;

namespace Tasks.Tests
{
    public class SpiralMatrixTests
    {
        private readonly SpiralMatrix _service = new SpiralMatrix();

        [Fact]
        public void Test1()
        {
            var result = _service.SpiralOrder(new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } });
            Assert.Equal(new List<int>(){ 1,2,3,6,9,8,7,4,5}, result);
        }
        
        [Fact]
        public void Test2()
        {
            var result = _service.SpiralOrder(new[] { new[] {1,2,3,4 }, new[] { 5,6,7,8 }, new[] { 9,10,11,12 } });
            Assert.Equal(new List<int>(){ 1,2,3,4,8,12,11,10,9,5,6,7 }, result);
        }
    }
}