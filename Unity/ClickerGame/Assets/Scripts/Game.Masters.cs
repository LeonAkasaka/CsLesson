using ClickerGame.Masters;
using ClickerGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Game
{
    public IEnumerable<ItemMaster> ItemMasters { get; private set; }

    public IEnumerable<EnhancerMaster> EnhancerMasters { get; private set; }

    private void LoadMasters() // TODO: 非同期化
    {
        // TODO: 仮データ。
        var items = new ItemMaster[]
        {
                new ItemMaster("Item1", new Currency(CurrencyType.Gold, 10), new Currency(CurrencyType.Gold, 0.1)),
                new ItemMaster("Item2", new Currency(CurrencyType.Gold, 100), new Currency(CurrencyType.Gold, 1)),
                new ItemMaster("Item3", new Currency(CurrencyType.Gold, 1000), new Currency(CurrencyType.Gold, 10)),
                new ItemMaster("Item4", new Currency(CurrencyType.Gold, 5000), new Currency(CurrencyType.Gold, 20)),
                new ItemMaster("Item5", new Currency(CurrencyType.Gold, 10000), new Currency(CurrencyType.Gold, 50)),
                new ItemMaster("Item6", new Currency(CurrencyType.Gold, 30000), new Currency(CurrencyType.Gold, 100)),
        };

        var enhancers = new EnhancerMaster[]
        {
            new EnhancerMaster("Enhancer1", new Currency(CurrencyType.Gold, 10), items[0], 2),
            new EnhancerMaster("Enhancer2", new Currency(CurrencyType.Gold, 100), items[1], 2),
        };

        ItemMasters = items;
        EnhancerMasters = enhancers;
    }
}