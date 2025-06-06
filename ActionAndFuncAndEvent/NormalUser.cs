public class NormalUser : IUser
{
    public string Name { get; set; }
    public ShopingCartModel ShopingCart { get; set; }

    public decimal GetDiscountedPrice(decimal totalprice)
    {

        if (ShopingCart.Item.Count > 5)
        {

            return totalprice * (1 - 0.30M);
        }
        else
        {
            return totalprice;
        }
    }
}
