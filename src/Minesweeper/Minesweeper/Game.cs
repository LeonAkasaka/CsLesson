using System;

namespace Minesweeper
{
    public static class Game
    {
        /// <summary>
        /// 指定セルの隣接する8マスの地雷数を取得する。
        /// 指定セルが地雷の場合は -1 を返す。
        /// </summary>
        /// <remarks>
        /// 各セルの状態は <paramref name="cells"/> パラメーターから取得できる。
        /// <paramref name="cells"/> パラメーターは行番号・列番号の順で、指定のセルに地雷があるかどうかを格納する。
        /// true なら地雷がある、そうでなければ地雷がない。
        /// <code>cells[row, column]</code> の周辺8マスの地雷数を数える。
        /// </remarks>
        /// <param name="cells">行・列順の地雷があるかどうかの2次元配列。</param>
        /// <param name="row">セルの行番号。</param>
        /// <param name="column">セルの列番号。</param>
        /// <returns>隣接する8マスの地雷数。</returns>
        public static int Count(bool[,] cells, int row, int column)
        {
            throw new NotImplementedException();
        }
    }
}
