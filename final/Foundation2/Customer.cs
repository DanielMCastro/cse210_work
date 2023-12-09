public class Customer
{
    private string name;
    Address address = new Address();

    public bool IsUsa()
    {
        return address.IsUsa();
    }

    public string GetCustomerName()
    {
        return name;
    }

    public string GetCustomerAddress()
    {
        return address.GetAddress();
    }

    public void SetCustomerName(string customerName)
    {
        name = customerName;
    }

    public void SetAddress(string cAddress, string cCity, string cState, string cCountry)
    {
        address.SetAddress(cAddress, cCity, cState, cCountry);
    }
}