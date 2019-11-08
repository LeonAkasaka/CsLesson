using ClickerGame.Masters;
using System;
using System.Collections.Generic;

namespace ClickerGame.Models
{
    public class ItemInventory
    {
        private readonly Dictionary<ItemMaster, int> _items = new Dictionary<ItemMaster, int>();

        /// <summary>
        /// アイテムに変更があった。
        /// </summary>
        public Action<ItemMaster, int> Changed;

        /// <summary>
        /// 1秒間の生産量。
        /// </summary>
        public IDictionary<CurrencyType, double> ProductivitiesPerSec => _productivitiesPerSec;
        private Dictionary<CurrencyType, double> _productivitiesPerSec = new Dictionary<CurrencyType, double>();

        /// <summary>
        /// コンストラクター。
        /// </summary>
        public ItemInventory()
        {
            var dic = _productivitiesPerSec;
            foreach (var key in Enum.GetValues(typeof(CurrencyType)))
            {
                dic.Add((CurrencyType)key, 0);
            }
        }

        /// <summary>
        /// アイテムを追加する。
        /// </summary>
        /// <param name="item">追加するアイテム。</param>
        public void Add(ItemMaster item)
        {
            if (item == null) { throw new ArgumentNullException(nameof(item)); }

            var count = 0;
            if (_items.TryGetValue(item, out count))
            {
                count++;
                _items[item] = count;
            }
            else
            {
                count = 1;
                _items.Add(item, count);
            }

            foreach (var p in item.Productivities)
            {
                _productivitiesPerSec[p.Type] += p.Quantity; ;
            }
            Changed?.Invoke(item, count);
        }

        /// <summary>
        /// アイテムの所有数を取得する。
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int GetCount(ItemMaster item)
        {
            if (item == null) { throw new ArgumentNullException(nameof(item)); }

            if (_items.TryGetValue(item, out int count))
            {
                return count;
            }
            return 0;
        }

        /// <summary>
        /// 価格を取得する。
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public Currency GetPrice(ItemMaster item)
        {
            if (item == null) { throw new ArgumentNullException(nameof(item)); }

            var c = GetCount(item);
            return new Currency(item.Price.Type, item.Price.Quantity);
        }
    }
}
