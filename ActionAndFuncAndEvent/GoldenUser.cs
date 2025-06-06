public class GoldenUser : IUser
{
    public string Name { get; set; }
    public ShopingCartModel ShopingCart { get; set; }

    public decimal GetDiscountedPrice(decimal totalprice)
    {
        return totalprice * (1 - 0.30M);

    }
}
