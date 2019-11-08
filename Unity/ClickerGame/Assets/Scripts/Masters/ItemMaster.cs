using ClickerGame.Models;
using System;
using System.Collections.Generic;

namespace ClickerGame.Masters
{
    /// <summary>
    /// アイテムマスター。
    /// </summary>
    public class ItemMaster
    {
        /// <summary>
        /// アイテム名。
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// 基準価格。
        /// </summary>
        public Currency Price { get; }

        /// <summary>
        /// 1秒間の生産量。
        /// </summary>
        public IEnumerable<Currency> Productivities { get; }

        /// <summary>
        /// コンストラクター。
        /// </summary>
        /// <param name="name">アイテム名。</param>
        /// <param name="price">基準価格。</param>
        /// <param name="productivities">1秒間の生産量。</param>
        public ItemMaster(string name, Currency price, params Currency[] productivities)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Price = price;
            Productivities = productivities ?? throw new ArgumentNullException(nameof(productivities));
        }
    }
}
