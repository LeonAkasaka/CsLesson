using FibonacciSequence;
using Xunit;

namespace FibonacciSequenceUnitTest
{
    public class FibonacciSequencerUnitTest
    {
        [Fact]
        public void EnumerableUnitTest()
        {
            var numbers = TestData.Numbers;
            var fs = new FibonacciSequencer();
            var i = 0;
            foreach(var actual in fs)
            {
                var expected = numbers.Span[i++];
                Assert.Equal(expected, actual);
            }
        }
    }
}
