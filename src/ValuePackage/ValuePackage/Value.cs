using System;

namespace ValuePackage
{
    public static class Value
    {
        /// <summary>
        /// 2つの 16 ビット値を 32 ビットにパッケージする。
        /// </summary>
        /// <remarks>
        /// <see cref="short"/> 型は 16 ビットなので、32ビット型の <see cref="int"/> の半分に相当する。
        /// 2つの <see cref="short"/> 型の値を 1 つの <see cref="int"/> 型にまとめて保存しておけるはず。
        /// </remarks>
        /// <param name="s1">最初の16ビット値。</param>
        /// <param name="s2">2番目の16ビット値。</param>
        /// <returns>2つの値をまとめた32ビット値。</returns>
        public static int Pack(short s1, short s2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// <see cref="Pack(short, short)"/> が返した値を、元の2つの <see cref="short"/> 型に分解する。
        /// </summary>
        /// <param name="value">2つの <see cref="short"/> がパックされた値。</param>
        /// <returns>分解した2つの <see cref="short"/> 値。</returns>
        public static (short, short) UnpackToShort(int value)
        {
            throw new NotImplementedException();
        }
    }
}
