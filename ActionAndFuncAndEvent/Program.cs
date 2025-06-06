

IUser normaluser = new NormalUser() { Name = "Martin" };
IUser goldenUser = new GoldenUser() { Name = "Heshmat" };


normaluser.ShopingCart = fillShopingcart();
goldenUser.ShopingCart = fillShopingcart();


decimal normaluserprice = normaluser.ShopingCart.Getfinalprice();
decimal goldenuserprice = goldenUser.ShopingCart.Getfinalprice();


Console.WriteLine($"normal User :{normaluserprice :C2}");
Console.WriteLine();
Console.WriteLine($"Golden User :{goldenuserprice:C2}");





ShopingCartModel fillShopingcart()
{
     ShopingCartModel cart = new ShopingCartModel();

    cart.Item.Add(new ProductModel() { Name = "Iphone 16", price = 10.5M });
    cart.Item.Add(new ProductModel() { Name = "Laptop", price = 15.5M });
    cart.Item.Add(new ProductModel() { Name = "KeyBord", price = 20M });
    cart.Item.Add(new ProductModel() { Name = "Mouse", price = 18.8M });


    return cart;
}
