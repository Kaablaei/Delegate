public interface IUser
{

    string Name { get; set; }
    ShopingCartModel ShopingCart { get; set; }
    decimal GetDiscountedPrice(decimal totalprice);
}
