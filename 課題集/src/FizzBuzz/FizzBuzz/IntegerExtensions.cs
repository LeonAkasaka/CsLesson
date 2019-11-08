using System;

namespace FizzBuzz
{
    public static class IntegerExtensions
    {
        /// <summary>
        /// 3で割り切れるかどうかを取得する。
        /// </summary>
        /// <param name="value">調べる値。</param>
        /// <returns>3で割り切れるなら true。そうでなければ false。</returns>
        public static bool IsFizz(this uint value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 5で割り切れるかどうかを取得する。
        /// </summary>
        /// <param name="value">調べる値。</param>
        /// <returns>5で割り切れるなら true。そうでなければ false。</returns>
        public static bool IsBuzz(this uint value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 3と5で割り切れるかどうかを取得する。
        /// </summary>
        /// <param name="value">調べる値。</param>
        /// <returns>3と5で割り切れるなら true。そうでなければ false。</returns>
        public static bool IsFizzBuzz(this uint value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 整数から Fizz Buzz 文字列を取得する。
        /// </summary>
        /// <remarks>
        /// 3で割り切れる場合は「Fizz」、5で割り切れる場合は「Buzz」、両者で割り切れる場合は「Fizz Buzz」。
        /// そうでなければ、元の整数をそのまま文字列にしたものになる。
        /// </remarks>
        /// <param name="value">Fizz Buzz 文字列にする整数。</param>
        /// <returns>Fizz Buzz 文字列</returns>
        public static string ToFizzBuzz(this uint value)
        {
            throw new NotImplementedException();
        }
    }
}
