public class Product
{
    private string productName;
    private int productId;
    private double productPrice;
    private double productQuantity;

    public Product(string name, int id, double price, double quantity)
    {
        productName = name;
        productId = id;
        productPrice = price;
        productQuantity = quantity;
    }

    public double CalculatePrice()
    {
        return productPrice * productQuantity;
    }

    /*public string GetProductName()
    {
        return productName;
    }

    public int GetProductId()
    {
        return productId;
    }*/

    public string GetProductInfo()
    {
        return $"{productName}: {productId}\n";
    }
}