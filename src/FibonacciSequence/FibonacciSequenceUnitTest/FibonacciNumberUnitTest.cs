using FibonacciSequence;
using System;
using Xunit;

namespace FibonacciSequenceUnitTest
{
    public class FibonacciNumberUnitTest
    {
        [Fact]
        public void GetValueTest()
        {
            var numbers = TestData.Numbers;
            for (var i = 0; i < numbers.Length; i++)
            {
                var expected = numbers.Span[i];
                var actual = FibonacciNumber.GetValue(i);
                Assert.Equal(expected, actual);
            }
        }
    }
}
