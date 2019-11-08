using System;
using UnityEngine;
using UnityEngine.UI;

public class EnhancerView : MonoBehaviour
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

    public EnhancerItem DataSource
    {
        get => _item;
        set
        {
            if (_item != null)
            {
            }
            if (value != null)
            {
            }

            _item = value;
            UpdateDataSource(_item);
        }
    }
    private EnhancerItem _item;

    public event Action<EnhancerItem> ItemSelected;

    private void Update()
    {
        _maskObject.SetActive(!Game.Instance.CanPurchase(_item.Master));
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

    private void UpdateDataSource(EnhancerItem item)
    {
        if (item != null)
        {
            _nameText.text = item.Master.Name;
            var price = item.Price;
            _priceText.text =
                $"{price.Quantity}({price.Type})";
        }
        else
        {
            _nameText.text = "";
            _priceText.text = "";
        }
    }
}
