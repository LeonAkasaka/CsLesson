using ClickerGame.Masters;
using ClickerGame.Models;
using System;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// アイテム情報を表示するビュー。
/// </summary>
public class ItemView : MerchandiseView<MerchandiseItem>
{
    [SerializeField]
    private Text _countText = null;

    protected override bool CanPurchase => !Game.Instance.CanPurchase(DataSource.Master);

    protected override void OnInitialize(MerchandiseItem merchandise)
    {
        base.OnInitialize(merchandise);
        merchandise.CountChanged += OnCounteChanged;
    }
    protected override void OnRelease(MerchandiseItem merchandise)
    {
        base.OnRelease(merchandise);
        merchandise.CountChanged -= OnCounteChanged;
    }

    private void OnCounteChanged(MerchandiseItem merchandise) => OnDataSourceChanged();

    protected override void OnDataSourceChanged()
    {
        base.OnDataSourceChanged();

        if (DataSource != null)
        {
            _countText.text = DataSource.Count.ToString();
        }
        else
        {
            _countText.text = "";
        }
    }
}
