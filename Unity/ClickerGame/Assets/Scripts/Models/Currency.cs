namespace ClickerGame.Models
{
    /// <summary>
    /// 通貨種類。
    /// </summary>
    public enum CurrencyType
    {
        /// <summary>
        /// なし。
        /// </summary>
        None,

        /// <summary>
        /// ゴールド。
        /// </summary>
        Gold,
    }

    /// <summary>
    /// 通貨。
    /// </summary>
    /// <remarks>
    /// 通貨よりも資源（Resource）のほうがいい気がしてきた。
    /// けど、Unity の Resource と用語が被るので迷う。
    /// </remarks>
    public struct Currency
    {
        /// <summary>
        /// 種類。
        /// </summary>
        public CurrencyType Type { get; }

        /// <summary>
        /// 量。
        /// </summary>
        public double Quantity { get; }

        /// <summary>
        /// コンストラクター。
        /// </summary>
        /// <param name="value">量。</param>
        /// <param name="type">種類。</param>
        public Currency(CurrencyType type, double value)
        {
            Type = type;
            Quantity = value;
        }

        public override string ToString() => $"{Quantity}({Type})";
    }
}
