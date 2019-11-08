using System.Collections.Generic;
using System.Linq;

namespace ClickerGame.Models
{
    /// <summary>
    /// 販売所。
    /// </summary>
    public class Store
    {
        /// <summary>
        /// 販売しているアイテム一覧。
        /// </summary>
        public IEnumerable<StoreItem> Items { get; }

        /// <summary>
        /// コンストラクター。
        /// </summary>
        public Store()
        {
            var game = Game.Instance;
            var inventory = game.ItemInventory;
            Items = game.ItemMasters.Select(x => new StoreItem(x, inventory.GetPrice(x), inventory.GetCount(x)));
        }
    }
}
