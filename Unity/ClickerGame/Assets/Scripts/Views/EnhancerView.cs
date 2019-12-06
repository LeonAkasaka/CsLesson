public class EnhancerView : MerchandiseView<MerchandiseEnhancer>
{
    protected override bool CanPurchase => Merchandise.IsPurchased || !Game.Instance.CanPurchase(Merchandise.Master);
}
