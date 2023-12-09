public class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    public Address()
    {}

    /*public Address(string aStreet, string aCity, string aState, string aCountry)
    {
        street = aStreet;
        city = aCity;
        state = aState;
        country = aCountry;
    }*/

    public bool IsUsa()
    {
        if (country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetAddress()
    {
        return $"Address: {street}, {city} {state}, {country}";
    }

    public void SetAddress(string aStreet, string aCity, string aState, string aCountry)
    {
        street = aStreet;
        city = aCity;
        state = aState;
        country = aCountry;
    }
}