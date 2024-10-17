public class Order 
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void addToCart(Product product)
    {
        _products.Add(product);
    }

    public int Shipping()
    {   
        if (_customer.IsUsa() == true)
        {
            return 5;
        }
        else 
        {
            return 35;
        }
    }

    public string TotalCartCost()
    {
        float totalCost = 0;

        foreach(Product product in _products)
        {
            totalCost += product.totalUnitCost();
        }
        int shippingCost = Shipping();
        totalCost += shippingCost; 

        return $"\nTOTAL COST WITH SHIPPING(${shippingCost})\n${totalCost}";

    }

    public string PackingLabel()
    {   
        string label = "";
        foreach (Product product in _products)
        {
            label += $"\nProduct Name: {product.Name}\nProduct ID: {product.ProductId}\nQuantity: {product.Quantity}\n";
        }
        return $"\nPACKING LABEL" + label;
    }

    public string ShippingLabel()
    {
        return $"SHIPPING ADDRESS\n" +_customer.GetDisplayAddress();
    }
}

