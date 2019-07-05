using Reversi;
using Xunit;

namespace ReversiUnitTest
{
    public class GameUnitTest
    {
        [Fact]
        public void DefaultTest()
        {
            var game = new Game();
            var result = game.Play("");

            Assert.Equal(2, result.DarkCount);
            Assert.Equal(2, result.LightCount);
        }
    }
}
