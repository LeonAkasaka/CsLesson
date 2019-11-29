using ClickerGame.Masters;
using ClickerGame.Models;
using System;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// アイテム情報を表示するビュー。
/// </summary>
public class ItemView : MonoBehaviour
{
    [SerializeField]
    private Button _button = null;

    [SerializeField]
    private GameObject _maskObject = null;

    [SerializeField]
    private Image _image = null;

    [SerializeField]
    private Text _nameText = null;

    [SerializeField]
    private Text _priceText = null;

    [SerializeField]
    private Text _countText = null;

    /// <summary>
    /// このビューに表示するアイテム情報。
    /// </summary>
    public StoreItem DataSource
    {
        get => _item;
        set
        {
            if (_item != null)
            {
                _item.PriceChanged -= OnPriceChanged;
                _item.CountChanged -= OnCounteChanged;
            }
            if (value != null)
            {
                value.PriceChanged += OnPriceChanged;
                value.CountChanged += OnCounteChanged;
            }

            _item = value;
            UpdateDataSource(_item);
        }
    }

    private StoreItem _item;

    /// <summary>
    /// アイテムが選択されたときに呼び出されるイベント。
    /// </summary>
    public event Action<StoreItem> ItemSelected;

    private void Update()
    {
        _maskObject.SetActive(!Game.Instance.CanPurchase(_item.Master));
    }

    private void OnPriceChanged(Merchandise<ItemMaster> merchandise) => UpdateDataSource(DataSource);
    private void OnCounteChanged(StoreItem item) => UpdateDataSource(DataSource);

    private void UpdateDataSource(StoreItem item)
    {
        if (item != null)
        {
            _nameText.text = item.Master.Name;
            var price = item.Price;
            _priceText.text =
                $"{price.Quantity}({price.Type})";
            _countText.text = item.Count.ToString();
        }
        else
        {
            _nameText.text = "";
            _priceText.text = "";
            _countText.text = "";
        }
    }

    void Start()
    {
        var e = new Button.ButtonClickedEvent();
        e.AddListener(() =>
        {
            ItemSelected?.Invoke(_item);
        });
        _button.onClick = e;
    }
}
