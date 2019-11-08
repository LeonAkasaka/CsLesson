using System;

namespace Reversi
{
    /// <summary>
    /// オセロゲーム。
    /// </summary>
    public class Game
    {
        /// <summary>
        /// ゲームを実行する。
        /// </summary>
        /// <remarks>
        /// <paramref name="record"/> にはゲームの棋譜データが文字列として渡される。
        /// 棋譜は黒を先手として、交互に碁盤に石を置いた場所を表す。
        /// 碁盤の座標は列を左から a - h のアルファベット、行を上から 1 - 8 までの数値で表す。
        /// 
        /// 例えば「c4c5e6f5f3」なら、D が黒、L が白として、碁盤は次の状態になる。
        /// --------
        /// --------
        /// -----L--
        /// --DDL---
        /// --LLLL--
        /// ----D---
        /// --------
        /// --------
        /// 
        /// よって、結果は黒が3、白が5となる。
        /// 
        /// <paramref name="record"/> が null の場合 <see cref="ArgumentNullException" /> 例外を投げる。
        /// 棋譜に不正な文字が含まれている場合 <see cref="ArgumentException"/> 例外を投げる。
        /// 棋譜に置くことができない場所が指定された場合 <see cref="InvalidOperationException"/> 例外を投げる。
        /// 範囲外の座標が指定された場合 <see cref="ArgumentOutOfRangeException"/> 例外を投げる。
        /// 
        /// </remarks>
        /// <param name="record">棋譜。</param>
        /// <returns>ゲーム結果。</returns>
        public GameResult Play(string record)
        {
            throw new NotImplementedException();
        }
    }
}
