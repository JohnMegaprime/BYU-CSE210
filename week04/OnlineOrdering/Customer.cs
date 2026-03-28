
public class Customer
{
    private string _name;

    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LiveUsa()
    {
        if (_address.GetCountry() == "USA" || _address.GetCountry() == "United States")
            return true;
        else
            return false;
    }

    public string GetName()
    {
        string name = _name;
        return name;
    }

    public string GetAddressText()
    {
        string text = _address.DisplayAddress();
        return text;
    }
    
}