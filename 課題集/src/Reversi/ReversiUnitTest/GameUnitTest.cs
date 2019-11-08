using Reversi;
using System;
using System.Collections.Generic;
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

            // ゲーム開始時の状態。
            Assert.Equal(2, result.DarkCount);
            Assert.Equal(2, result.LightCount);
        }

        [Fact(DisplayName = "null")]
        public void ArgumentDirtyTest1()
        {
            var game = new Game();
            Assert.Throws<ArgumentNullException>(() => game.Play(null));
        }

        [Fact(DisplayName = "無効な文字を含む棋譜")]
        public void ArgumentDirtyTest2()
        {
            var game = new Game();
            Assert.Throws<ArgumentException>(() => game.Play("This is invalid data."));
            Assert.Throws<ArgumentException>(() => game.Play("*"));
            Assert.Throws<ArgumentException>(() => game.Play("12345"));
            Assert.Throws<ArgumentException>(() => game.Play("123456"));
            Assert.Throws<ArgumentException>(() => game.Play("c4c5????"));
        }

        [Fact(DisplayName = "有効っぽいけど範囲外")]
        public void ArgumentDirtyTest3()
        {
            var game = new Game();
            Assert.Throws<ArgumentOutOfRangeException>(() => game.Play("a0"));
            Assert.Throws<ArgumentOutOfRangeException>(() => game.Play("a9"));
            Assert.Throws<ArgumentOutOfRangeException>(() => game.Play("h0"));
            Assert.Throws<ArgumentOutOfRangeException>(() => game.Play("h9"));
            Assert.Throws<ArgumentOutOfRangeException>(() => game.Play("i1"));
            Assert.Throws<ArgumentOutOfRangeException>(() => game.Play("i0"));
            Assert.Throws<ArgumentOutOfRangeException>(() => game.Play("i9"));  
        }

        public static IEnumerable<object[]> TestData
        {
            get
            {
                yield return new object[] { "f5f4d3c4e3e6b5d2c2f3f7b2d1c3e2d6b1b4g4g8b3g2g3g5c7b8f6a2h6a4d7e7a3c1c5h5g6a1f8f2g1h2a5b6h4h3b7c6a6g7f1a7d8c8e8e1h8h1a8h7", 17, 47 };
                yield return new object[] { "f5d6c5f6e7c7c4b4g7d3c2c3b8d2d1h8b5g5a4a5h4a3c6c1a6d7g6e2f4h7b2c8a2b3b1a8g8e6f7g4f1e8b6f8b7d8e3f3h3f2g2h6g3g1h1a1h5h2e1a7", 27, 37 };
                yield return new object[] { "c4e3f3c3f5d6c5b4d7f4g3c6b6a7e2g4g5d8d3f1e1h5a4f2g2g1h3c7h1b5e6g6c8h4e7f6c2d1h6b8d2b1b7b3f8e8b2a1a6h2g7a5a2h8c1h7f7a3g8a8", 28, 36 };
                yield return new object[] { "e6f4g3g4d3d6c6g2f5d7e7b5b7c2e3f7h2f3e2f1h1d2g8f2e8h3a4c8g5a6c1c5d8b6g1a5b2f6b4f8e1b1c7h8h4c4a1a3c3h6b8h5h7a8g6b3a2g7a7d1", 42, 22 };
            }
        }

        [Theory()]
        [MemberData(nameof(TestData))]
        public void PlayTest(string record, int dark, int light)
        {
            var game = new Game();
            var result = game.Play(record);

            Assert.Equal(dark, result.DarkCount);
            Assert.Equal(light, result.LightCount);
        }
    }
}
