using ClickerGame.Masters;
using System;

namespace ClickerGame.Models
{
    /// <summary>
    /// アイテムの情報。
    /// </summary>
    /// <remarks>
    /// 同系統の項目を複数購入可能で、所持数に応じて効果が加算されていく想定。
    /// </remarks>
    public class StoreItem : Merchandise<ItemMaster>
    {
        /// <summary>
        /// 現在の所有数。
        /// </summary>
        public int Count { get => _count; set { _count = value; CountChanged?.Invoke(this); } }
        private int _count;
        public event Action<StoreItem> CountChanged;

        /// <summary>
        /// コンストラクター。
        /// </summary>
        /// <param name="master">商品のマスターデータ。</param>
        /// <param name="price">購入価格。</param>
        public StoreItem(ItemMaster master, Currency price, int count) : base(master, price)
        {
            Count = count;
        }

        /// <summary>
        /// このアイテムの購入を要求する。
        /// </summary>
        public override void Purchase()
        {
            var game = Game.Instance;
            if (game.TryPurchase(Master))
            {
                var inventory = game.ItemInventory;
                Price = inventory.GetPrice(Master);
                Count = inventory.GetCount(Master);
            }
        }
    }
}