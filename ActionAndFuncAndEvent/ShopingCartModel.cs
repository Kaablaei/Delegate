public class ShopingCartModel
{
    public List<ProductModel> Item { get; set; } = new List<ProductModel>();


    public delegate decimal ComputeDiscountedPrice(decimal price);

    public delegate void printDiscountValue(decimal totalPrice, decimal finalPrice);

    public decimal Getfinalprice(Func<List<ProductModel>, decimal> Calculatprice,
        ComputeDiscountedPrice discountedPrice,
        printDiscountValue printDiscountValue)
    {
        decimal totoal = Calculatprice(Item);

        decimal discountedvalue = discountedPrice(totoal);

        printDiscountValue(totoal , discountedvalue);

        return discountedvalue;
    }

}
