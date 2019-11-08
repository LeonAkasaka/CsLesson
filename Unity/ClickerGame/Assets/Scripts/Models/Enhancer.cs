using System.Collections.Generic;
using System.Linq;

namespace ClickerGame.Models
{
    public class Enhancer
    {
        /// <summary>
        /// 販売しているアイテム一覧。
        /// </summary>
        public IEnumerable<EnhancerItem> Items { get; }

        /// <summary>
        /// コンストラクター。
        /// </summary>
        public Enhancer()
        {
            var game = Game.Instance;
            var inventory = game.EnhancerInventory;
            Items = game.EnhancerMasters.Select(x => new EnhancerItem(x, inventory.GetPrice(x)));

        }
    }
}