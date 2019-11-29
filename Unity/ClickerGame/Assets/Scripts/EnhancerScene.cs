using ClickerGame.Models;
using System.Linq;
using UnityEngine;

public class EnhancerScene : MonoBehaviour
{
    [SerializeField]
    private EnhancerView _prefab = null;

    [SerializeField]
    private GameObject _itemsContainer = null;

    public Store<EnhancerItem> DataSource
    {
        get => _dataSource;
        set
        {
            _dataSource = value;
            UpdateDataSource();
        }
    }
    private Store<EnhancerItem> _dataSource;

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

    private void ItemView_ItemSelected(EnhancerItem enhancer)
    {
        enhancer.Purchase();
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
        var inventory = game.EnhancerInventory;
        var enhancers = game.EnhancerMasters.Select(x => new EnhancerItem(x, inventory.GetPrice(x)));
        DataSource = new Store<EnhancerItem>(enhancers); // 仮
    }
}
