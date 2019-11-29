using ClickerGame.Masters;
using ClickerGame.Models;
using System.Linq;
using UnityEngine;

public class StoreScene : MonoBehaviour
{
    [SerializeField]
    private ItemView _prefab = null;

    [SerializeField]
    private GameObject _itemsContainer = null;

    public Store<StoreItem> DataSource
    {
        get => _dataSource;
        set
        {
            _dataSource = value;
            UpdateDataSource();
        }
    }
    private Store<StoreItem> _dataSource;

    private void UpdateDataSource()
    {
        ClearItems();

        var t = _itemsContainer.transform;
        foreach (var item in DataSource.Merchandises)
        {
            var itemView = Instantiate(_prefab, t);
            itemView.ItemSelected += ItemView_ItemSelected;
            itemView.DataSource = item;
        }
    }

    private void ItemView_ItemSelected(StoreItem item)
    {
        item.Purchase();
    }

    private void ClearItems()
    {
        var t = _itemsContainer.transform;
        for (var i = 0; i < t.childCount; i++)
        {
            var obj = t.GetChild(i);
            Destroy(obj.gameObject);
        }
    }

    void Start()
    {
        var game = Game.Instance;
        var inventory = game.ItemInventory;
        var items = game.ItemMasters.Select(x => new StoreItem(x, inventory.GetPrice(x), inventory.GetCount(x)));
        DataSource = new Store<StoreItem>(items); // 仮
    }
}