using ClickerGame.Masters;
using System;

namespace ClickerGame.Models
{
    /// <summary>
    /// アイテムの情報。
    /// </summary>
    public class StoreItem
    {
        /// <summary>
        /// アイテムマスター。
        /// </summary>
        public ItemMaster Master { get; }

        /// <summary>
        /// 購入価格。
        /// </summary>
        public Currency Price { get => _currency; set { _currency = value; PriceChanged?.Invoke(this); } }
        private Currency _currency;
        public event Action<StoreItem> PriceChanged;

        /// <summary>
        /// 現在の所有数。
        /// </summary>
        public int Count { get => _count; set { _count = value; CountChanged?.Invoke(this); } }
        private int _count;
        public event Action<StoreItem> CountChanged;

        /// <summary>
        /// コンストラクター。
        /// </summary>
        /// <param name="name">アイテム名。</param>
        /// <param name="price">購入価格。</param>
        /// <param name="productivity">1秒間の生産量。</param>
        public StoreItem(ItemMaster master, Currency price, int count)
        {
            Master = master;
            Price = price;
            Count = count;
        }
    }
}