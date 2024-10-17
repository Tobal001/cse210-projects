public class Customer 
{
    private string _name;
    private Address _address;

    public Customer( string name, Address adress) 
    {
        _name = name;
        _address = adress;
    }

    public string Name 
    {
       get  {return _name;}
    }



    public bool IsUsa()
    {
        return _address.IsUsa();
    }

    public string GetDisplayAddress()
    {   
        return _address.GetDisplayText();
    }
}