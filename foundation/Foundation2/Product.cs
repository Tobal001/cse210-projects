using System.Numerics;

public class Product 
{
    private string _name;
    private int _productId;
    private float _price;
    private int _quantity;

    public Product(string name, int productId, float price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

      public string Name
    {
        get { return _name; }
    }

    public int ProductId
    {
        get { return _productId; }
    }

    public int Quantity 
    {
        get {return _quantity;}
    }
    
    public float Price
    {
        get { return _price; }
    }

    public float totalUnitCost()
    {
        float total = _price * _quantity;
        return total;
    }
}