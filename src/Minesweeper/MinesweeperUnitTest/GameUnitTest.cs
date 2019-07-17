using Minesweeper;
using System;
using Xunit;

namespace MinesweeperUnitTest
{
    public class GameTest
    {
        [Fact(DisplayName = "null 例外テスト")]
        public void CountNullTest()
        {
            Assert.Throws<ArgumentNullException>(() => Game.Count(null, 0, 0));
        }

        [Fact(DisplayName = "Out of range 例外テスト")]
        public void CountOutOfRangeTest()
        {
            var data = new bool[,] { };
            Assert.Throws<ArgumentOutOfRangeException>(() => Game.Count(data, 0, 0));
        }

        [Fact(DisplayName = "1セルしかないテスト")]
        public void CountOneCellTest()
        {
            var mine = new bool[,] { { true } };
            Assert.Equal(-1, Game.Count(mine, 0, 0));

            var none = new bool[,] { { true } };
            Assert.Equal(0, Game.Count(none, 0, 0));
        }

        [Fact(DisplayName = "2 x 2: LeftTop")]
        public void Count2x2LeftTopTest()
        {
            var data = new bool[2, 2] { { true, false }, { false, false } };
            Assert.Equal(-1, Game.Count(data, 0, 0));
            Assert.Equal(1, Game.Count(data, 0, 1));
            Assert.Equal(1, Game.Count(data, 1, 0));
            Assert.Equal(1, Game.Count(data, 1, 1));
        }

        [Fact(DisplayName = "2 x 2: RightTop")]
        public void Count2x2RightTopTest()
        {
            var data = new bool[2, 2] { { false, true }, { false, false } };
            Assert.Equal(1, Game.Count(data, 0, 0));
            Assert.Equal(-1, Game.Count(data, 0, 1));
            Assert.Equal(1, Game.Count(data, 1, 0));
            Assert.Equal(1, Game.Count(data, 1, 1));
        }

        [Fact(DisplayName = "2 x 2: LeftBottom")]
        public void Count2x2LeftBottomTest()
        {
            var data = new bool[2, 2] { { false, false }, { true, false } };
            Assert.Equal(1, Game.Count(data, 0, 0));
            Assert.Equal(1, Game.Count(data, 0, 1));
            Assert.Equal(-1, Game.Count(data, 1, 0));
            Assert.Equal(1, Game.Count(data, 1, 1));
        }

        [Fact(DisplayName = "2 x 2: RightBottom")]
        public void Count2x2RightBottomTest()
        {
            var data = new bool[2, 2] { { false, false }, { false, true } };
            Assert.Equal(1, Game.Count(data, 0, 0));
            Assert.Equal(1, Game.Count(data, 0, 1));
            Assert.Equal(1, Game.Count(data, 1, 0));
            Assert.Equal(-1, Game.Count(data, 1, 1));
        }

        [Fact(DisplayName = "3 x 3: LeftTop")]
        public void Count3x3LeftTopTest()
        {
            var data = new bool[3, 3] { { true, false, false }, { false, false, false }, { false, false, false } };
            Assert.Equal(-1, Game.Count(data, 0, 0));
            Assert.Equal(1, Game.Count(data, 0, 1));
            Assert.Equal(0, Game.Count(data, 0, 2));
            Assert.Equal(1, Game.Count(data, 1, 0));
            Assert.Equal(1, Game.Count(data, 1, 1));
            Assert.Equal(0, Game.Count(data, 1, 2));
            Assert.Equal(0, Game.Count(data, 2, 0));
            Assert.Equal(0, Game.Count(data, 2, 1));
            Assert.Equal(0, Game.Count(data, 2, 2));
        }

        [Fact(DisplayName = "3 x 3: MiddleTop")]
        public void Count3x3CenterTopTest()
        {
            var data = new bool[3, 3] { { false, true, false }, { false, false, false }, { false, false, false } };
            Assert.Equal(1, Game.Count(data, 0, 0));
            Assert.Equal(-1, Game.Count(data, 0, 1));
            Assert.Equal(1, Game.Count(data, 0, 2));
            Assert.Equal(1, Game.Count(data, 1, 0));
            Assert.Equal(1, Game.Count(data, 1, 1));
            Assert.Equal(1, Game.Count(data, 1, 2));
            Assert.Equal(0, Game.Count(data, 2, 0));
            Assert.Equal(0, Game.Count(data, 2, 1));
            Assert.Equal(0, Game.Count(data, 2, 2));
        }

        [Fact(DisplayName = "3 x 3: RightTop")]
        public void Count3x3RightTopTest()
        {
            var data = new bool[3, 3] { { false, false, true }, { false, false, false }, { false, false, false } };
            Assert.Equal(0, Game.Count(data, 0, 0));
            Assert.Equal(1, Game.Count(data, 0, 1));
            Assert.Equal(-1, Game.Count(data, 0, 2));
            Assert.Equal(0, Game.Count(data, 1, 0));
            Assert.Equal(1, Game.Count(data, 1, 1));
            Assert.Equal(1, Game.Count(data, 1, 2));
            Assert.Equal(0, Game.Count(data, 2, 0));
            Assert.Equal(0, Game.Count(data, 2, 1));
            Assert.Equal(0, Game.Count(data, 2, 2));
        }

        [Fact(DisplayName = "3 x 3: LeftMiddle")]
        public void Count3x3LeftCenterTest()
        {
            var data = new bool[3, 3] { { false, false, false }, { true, false, false }, { false, false, false } };
            Assert.Equal(1, Game.Count(data, 0, 0));
            Assert.Equal(1, Game.Count(data, 0, 1));
            Assert.Equal(0, Game.Count(data, 0, 2));
            Assert.Equal(-1, Game.Count(data, 1, 0));
            Assert.Equal(1, Game.Count(data, 1, 1));
            Assert.Equal(0, Game.Count(data, 1, 2));
            Assert.Equal(1, Game.Count(data, 2, 0));
            Assert.Equal(1, Game.Count(data, 2, 1));
            Assert.Equal(0, Game.Count(data, 2, 2));
        }

        [Fact(DisplayName = "3 x 3: Center")]
        public void Count3x3CenterTest()
        {
            var data = new bool[3, 3] { { false, false, false }, { false, true, false }, { false, false, false } };
            Assert.Equal(1, Game.Count(data, 0, 0));
            Assert.Equal(1, Game.Count(data, 0, 1));
            Assert.Equal(1, Game.Count(data, 0, 2));
            Assert.Equal(1, Game.Count(data, 1, 0));
            Assert.Equal(-1, Game.Count(data, 1, 1));
            Assert.Equal(1, Game.Count(data, 1, 2));
            Assert.Equal(1, Game.Count(data, 2, 0));
            Assert.Equal(1, Game.Count(data, 2, 1));
            Assert.Equal(1, Game.Count(data, 2, 2));
        }

        [Fact(DisplayName = "3 x 3: RightMiddle")]
        public void Count3x3RightCenterTest()
        {
            var data = new bool[3, 3] { { false, false, false }, { false, false, true }, { false, false, false } };
            Assert.Equal(0, Game.Count(data, 0, 0));
            Assert.Equal(1, Game.Count(data, 0, 1));
            Assert.Equal(1, Game.Count(data, 0, 2));
            Assert.Equal(0, Game.Count(data, 1, 0));
            Assert.Equal(1, Game.Count(data, 1, 1));
            Assert.Equal(-1, Game.Count(data, 1, 2));
            Assert.Equal(0, Game.Count(data, 2, 0));
            Assert.Equal(1, Game.Count(data, 2, 1));
            Assert.Equal(1, Game.Count(data, 2, 2));
        }


        [Fact(DisplayName = "3 x 3: LeftBottom")]
        public void Count3x3LeftBottomTest()
        {
            var data = new bool[3, 3] { { false, false, false }, { false, false, false }, { true, false, false } };
            Assert.Equal(0, Game.Count(data, 0, 0));
            Assert.Equal(0, Game.Count(data, 0, 1));
            Assert.Equal(0, Game.Count(data, 0, 2));
            Assert.Equal(1, Game.Count(data, 1, 0));
            Assert.Equal(1, Game.Count(data, 1, 1));
            Assert.Equal(0, Game.Count(data, 1, 2));
            Assert.Equal(-1, Game.Count(data, 2, 0));
            Assert.Equal(1, Game.Count(data, 2, 1));
            Assert.Equal(0, Game.Count(data, 2, 2));
        }

        [Fact(DisplayName = "3 x 3: MiddleBottom")]
        public void Count3x3MiddleBottomTest()
        {
            var data = new bool[3, 3] { { false, false, false }, { false, false, false }, { false, true, false } };
            Assert.Equal(0, Game.Count(data, 0, 0));
            Assert.Equal(0, Game.Count(data, 0, 1));
            Assert.Equal(0, Game.Count(data, 0, 2));
            Assert.Equal(1, Game.Count(data, 1, 0));
            Assert.Equal(1, Game.Count(data, 1, 1));
            Assert.Equal(1, Game.Count(data, 1, 2));
            Assert.Equal(1, Game.Count(data, 2, 0));
            Assert.Equal(-1, Game.Count(data, 2, 1));
            Assert.Equal(1, Game.Count(data, 2, 2));
        }

        [Fact(DisplayName = "3 x 3: RightBottom")]
        public void Count3x3RightBottomTest()
        {
            var data = new bool[3, 3] { { false, false, false }, { false, false, false }, { false, false, true } };
            Assert.Equal(0, Game.Count(data, 0, 0));
            Assert.Equal(0, Game.Count(data, 0, 1));
            Assert.Equal(0, Game.Count(data, 0, 2));
            Assert.Equal(0, Game.Count(data, 1, 0));
            Assert.Equal(1, Game.Count(data, 1, 1));
            Assert.Equal(1, Game.Count(data, 1, 2));
            Assert.Equal(0, Game.Count(data, 2, 0));
            Assert.Equal(1, Game.Count(data, 2, 1));
            Assert.Equal(-1, Game.Count(data, 2, 2));
        }

        [Fact(DisplayName = "3 x 3: Full")]
        public void Count3x3FullTest()
        {
            var data = new bool[3, 3] { { true, true, true }, { true, false, true }, { true, true, true } };
            Assert.Equal(8, Game.Count(data, 1, 1));
        }
    }
}
