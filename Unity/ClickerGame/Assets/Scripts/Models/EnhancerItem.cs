using ClickerGame.Masters;
using ClickerGame.Models;

public class EnhancerItem
{
    // <summary>
    /// 強化マスター。
    /// </summary>
    public EnhancerMaster Master { get; }

    /// <summary>
    /// 購入価格。
    /// </summary>
    public Currency Price { get; }

    /// <summary>
    /// コンストラクター。
    /// </summary>
    /// <param name="name">アイテム名。</param>
    /// <param name="price">購入価格。</param>
    /// <param name="productivity">1秒間の生産量。</param>
    public EnhancerItem(EnhancerMaster master, Currency price)
    {
        Master = master;
        Price = price;
    }
}
