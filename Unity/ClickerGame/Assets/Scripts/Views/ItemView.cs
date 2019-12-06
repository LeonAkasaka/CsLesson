using ClickerGame.Models;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// アイテム情報を表示するビュー。
/// </summary>
public class ItemView : MerchandiseView<MerchandiseItem>
{
    [SerializeField]
    private Text _countText = null;

    protected override bool CanPurchase => !Game.Instance.CanPurchase(Merchandise.Master);

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

    private void OnCounteChanged(MerchandiseItem merchandise) => OnMerchandiseChanged();

    protected override void OnMerchandiseChanged()
    {
        base.OnMerchandiseChanged();

        if (Merchandise != null)
        {
            _countText.text = Merchandise.Count.ToString();
        }
        else
        {
            _countText.text = "";
        }
    }
}
