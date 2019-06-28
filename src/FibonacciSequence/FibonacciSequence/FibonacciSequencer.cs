using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FibonacciSequence
{
    /// <summary>
    /// フィボナッチ数列。
    /// </summary>
    public class FibonacciSequencer : IEnumerable<uint>
    {
        /// <summary>
        /// フィボナッチ数列の反復子を取得する。
        /// </summary>
        /// <returns>フィボナッチ数列を提供する反復子。</returns>
        public IEnumerator<uint> GetEnumerator()
        {
            return null;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
