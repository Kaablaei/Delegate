public class ShopingCartModel
{
    public List<ProductModel> Item { get; set; } = new List<ProductModel>();



    public decimal Getfinalprice()
    {
     
        return Item.Sum(p => p.price);
    }

}
