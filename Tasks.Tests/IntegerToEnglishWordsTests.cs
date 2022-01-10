using Xunit;

namespace Tasks.Tests
{
    public class IntegerToEnglishWordsTests
    {
        private readonly IntegerToEnglishWords _service = new();

        [Fact]
        public void Test0()
        {
            var result = _service.NumberToWords(77);
            Assert.Equal("Seventy Seven", result);
        }
        
        [Fact]
        public void Test0_1()
        {
            var result = _service.NumberToWords(30);
            Assert.Equal("Thirty", result);
        }
        
        [Fact]
        public void Test0_2()
        {
            var result = _service.NumberToWords(107);
            Assert.Equal("One Hundred Seven", result);
        }
        
        [Fact]
        public void Test0_3()
        {
            var result = _service.NumberToWords(100);
            Assert.Equal("One Hundred", result);
        }
        
        [Fact]
        public void Test1()
        {
            var result = _service.NumberToWords(123);
            Assert.Equal("One Hundred Twenty Three", result);
        }
        
        [Fact]
        public void Test1_2()
        {
            var result = _service.NumberToWords(223);
            Assert.Equal("Two Hundred Twenty Three", result);
        }

        
        [Fact]
        public void Test2()
        {
            var result = _service.NumberToWords(12345);
            Assert.Equal("Twelve Thousand Three Hundred Forty Five", result);
        }
        
        [Fact]
        public void Test3()
        {
            var result = _service.NumberToWords(1234567);
            Assert.Equal("One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven", result);
        }
        
        [Fact]
        public void Test4()
        {
            var result = _service.NumberToWords(1234567891);
            Assert.Equal("One Billion Two Hundred Thirty Four Million Five Hundred Sixty Seven Thousand Eight Hundred Ninety One", result);
        }
        
        
        [Fact]
        public void Test5()
        {
            var result = _service.NumberToWords(1000);
            Assert.Equal("One Thousand", result);
        }
        
        [Fact]
        public void Test6()
        {
            var result = _service.NumberToWords(1000000);
            Assert.Equal("One Million", result);
        }
    }
}