public class Order
{
    public Customer customer = new Customer();
    List<Product> products = new List<Product>();

    public void SetAddress(string address, string city, string state, string country)
    {
        customer.SetAddress(address, city, state, country);
    }

    public int GetShippingCost()
    {
        if (customer.IsUsa() == true)
        {
            return 5;
        }
        else{
            return 35;
        }
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in products)
        {
            totalCost += product.CalculatePrice(); 
        }
        totalCost += GetShippingCost();
        return totalCost;
    }

    public string GetShippingLabel()
    {
        return $"{customer.GetCustomerName()} {customer.GetCustomerAddress()}";
    }

    public string GetPackingLabel()
    {
        string shippingLabel = "";
        int order = 1;
        foreach (Product product in products)
        {
            shippingLabel += $"{product.GetProductInfo()}";
            order ++;
        }
        return shippingLabel;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void SetCustomerName(string customerName)
    {
        customer.SetCustomerName(customerName);
    }
}