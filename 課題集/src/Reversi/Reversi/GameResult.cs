using System;
using System.Collections.Generic;
using System.Text;

namespace Reversi
{
    /// <summary>
    /// ゲームの結果。
    /// </summary>
    public struct GameResult
    {
        /// <summary>
        /// 黒石の数。
        /// </summary>
        public int DarkCount { get; }

        /// <summary>
        /// 白石の数。
        /// </summary>
        public int LightCount { get; }

        /// <summary>
        /// コンストラクター。
        /// </summary>
        /// <param name="dark">黒石の数。</param>
        /// <param name="light">白石の数。</param>
        public GameResult(int dark, int light) =>
            (DarkCount, LightCount) = (dark, light);
    }
}
