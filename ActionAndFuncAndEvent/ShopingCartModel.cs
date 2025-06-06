public class ShopingCartModel
{
    public List<ProductModel> Item { get; set; } = new List<ProductModel>();


    public delegate decimal ComputeDiscountedPrice(decimal price);

    public decimal Getfinalprice(ComputeDiscountedPrice discountedPrice)
    {
        decimal totoal = this.Item.Sum(p => p.price);

        return discountedPrice(totoal);

        //return Item.Sum(p => p.price);
    }

}
