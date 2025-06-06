public class ShopingCartModel
{
    public List<ProductModel> Item { get; set; } = new List<ProductModel>();


    public delegate decimal ComputeDiscountedPrice(decimal price);

    public decimal Getfinalprice(Func<List <ProductModel> ,decimal > Calculatprice,ComputeDiscountedPrice discountedPrice)
    {
        decimal totoal = Calculatprice(Item);

        return discountedPrice(totoal);


    }

}
