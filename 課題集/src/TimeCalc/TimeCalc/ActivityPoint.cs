using System;

namespace TimeCalc
{
    /// <summary>
    /// 時間で回復する行動ポイント。
    /// </summary>
    public struct ActivityPoint
    {
        /// <summary>
        /// 現在値。
        /// </summary>
        public int Current { get; }

        /// <summary>
        /// 最大値。
        /// </summary>
        public int Max { get; }

        /// <summary>
        /// 1ポイント回復するために必要な時間間隔。
        /// </summary>
        public TimeSpan Interval { get; }

        /// <summary>
        /// コンストラクター。
        /// </summary>
        /// <param name="current">現在値。</param>
        /// <param name="max">最大値。</param>
        /// <param name="interval">1ポイント回復するために必要な時間間隔。</param>
        public ActivityPoint(int current, int max, TimeSpan interval)
        {
            Current = current;
            Max = max;
            Interval = interval;
        }

        /// <summary>
        /// 最大値に回復するまでの間隔を取得する。
        /// </summary>
        /// <returns>最大値に回復するまでの間隔を取得する。</returns>
        public TimeSpan GetTotalRecoveryInterval()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 最大値まで回復する時間を取得する。
        /// </summary>
        /// <param name="now">現在時刻。</param>
        /// <returns>最大値に回復する予想時間。</returns>
        public DateTimeOffset GetMaxRevoveryTime(DateTimeOffset now)
        {
            throw new NotImplementedException();
        }
    }
}
