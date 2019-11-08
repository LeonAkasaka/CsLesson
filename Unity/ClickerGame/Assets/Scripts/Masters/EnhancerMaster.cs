using ClickerGame.Models;

namespace ClickerGame.Masters
{
    /// <summary>
    /// 強化マスター。
    /// </summary>
    public class EnhancerMaster
    {
        /// <summary>
        /// 強化名。
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// 価格。
        /// </summary>
        public Currency Price { get; }

        /// <summary>
        /// 強化対象アイテム。
        /// </summary>
        public ItemMaster ItemMaster { get; }

        /// <summary>
        /// 強化倍率。
        /// </summary>
        public double Factor { get; }

        /// <summary>
        /// コンストラクター。
        /// </summary>
        /// <param name="name">強化名。</param>
        /// <param name="price">価格。</param>
        /// <param name="itemMaster">強化対象アイテム。</param>
        /// <param name="factor">強化倍率。</param>
        public EnhancerMaster(string name, Currency price, ItemMaster itemMaster, double factor)
        {
            Name = name;
            Price = price;
            ItemMaster = itemMaster;
            Factor = factor;
        }
    }
}