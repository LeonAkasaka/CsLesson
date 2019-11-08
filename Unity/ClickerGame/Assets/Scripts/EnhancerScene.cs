using ClickerGame.Models;
using UnityEngine;

public class EnhancerScene : MonoBehaviour
{
    [SerializeField]
    private EnhancerView _prefab = null;

    [SerializeField]
    private GameObject _itemsContainer = null;

    public Enhancer DataSource
    {
        get => _dataSource;
        set
        {
            _dataSource = value;
            UpdateDataSource();
        }
    }
    private Enhancer _dataSource;

    private void UpdateDataSource()
    {
        ClearItems();

        var t = _itemsContainer.transform;
        foreach (var item in DataSource.Items)
        {
            var itemView = Instantiate(_prefab, t);
            itemView.ItemSelected += ItemView_ItemSelected;
            itemView.DataSource = item;
        }
    }

    private void ItemView_ItemSelected(EnhancerItem item)
    {
        var game = Game.Instance;
        game.TryPurchase(item.Master);
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
        DataSource = new Enhancer(); // 仮
    }
}
