using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame.Models
{
    public class Production : IDisposable
    {
        /// <summary>
        /// アイテム用インベントリー。
        /// </summary>
        public ItemInventory ItemInventory { get; }

        /// <summary>
        /// 教科用インベントリー。
        /// </summary>
        public EnhancerInventory EnhancerInventory { get; }

        /// <summary>
        /// コンストラクター。
        /// </summary>
        /// <param name="itemInventory">アイテム用インベントリー。</param>
        /// <param name="enhancerInventory">教科用インベントリー。</param>
        public Production(ItemInventory itemInventory, EnhancerInventory enhancerInventory)
        {
            ItemInventory = itemInventory ?? throw new ArgumentNullException(nameof(itemInventory));
            EnhancerInventory = enhancerInventory ?? throw new ArgumentNullException(nameof(enhancerInventory));

            ItemInventory.Changed += (_1, _2) => OnProductivityChanged();
            //EnhancerInventory.Changed += x => OnProductivityChanged();
        }

        private void OnProductivityChanged()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
