using System;
using ClickerGame.Masters;
using UnityEngine;
using UnityEngine.UI;

public class EnhancerView : MerchandiseView<MerchandiseEnhancer>
{
    protected override bool CanPurchase => Merchandise.IsPurchased || !Game.Instance.CanPurchase(Merchandise.Master);
}
