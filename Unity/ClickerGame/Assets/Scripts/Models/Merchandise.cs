using System;

namespace ClickerGame.Models
{
    /// <summary>
    /// 商品の基底クラス。
    /// </summary>
    /// <typeparam name="TMaster">商品のマスター型。</typeparam>
    public abstract class Merchandise<TMaster>
    {
        /// <summary>
        /// 商品のマスター。
        /// </summary>
        public TMaster Master { get; }

        /// <summary>
        /// 購入価格。
        /// </summary>
        public Currency Price { get => _currency; set { _currency = value; PriceChanged?.Invoke(this); } }
        private Currency _currency;

        /// <summary>
        /// <see cref="Price" /> が変更されたときに発生するイベント。
        /// </summary>
        public event Action<Merchandise<TMaster>> PriceChanged;

        /// <summary>
        /// コンストラクター。
        /// </summary>
        /// <param name="master">商品のマスター。。</param>
        /// <param name="price">購入価格。</param>
        public Merchandise(TMaster master, Currency price)
        {
            Master = master;
            Price = price;
        }

        /// <summary>
        /// このアイテムの購入を要求する。
        /// </summary>
        public abstract void Purchase();
    }
}