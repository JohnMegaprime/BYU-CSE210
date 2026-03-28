
public class Order
{
    private List<Product> _products = new List<Product>();

    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product, int quantity)
    {
        product.SetQuantity(quantity);
        _products.Add(product);
    }

    private double OrderTotalCost()
    {
        double sum = 0;
        double total;

        foreach (Product product in _products)
        {
            sum += product.GetTotalPrice();
        }

        if (_customer.LiveUsa())
            total = sum + 5;
        else
            total = sum + 35;

        return total;

    }

    public void DisplayPackagingLabel()
    {
        Console.WriteLine("Order Packaging Label:\n");

        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.GetProdName()} - {product.GetProdID()} | QTD: {product.GetProdQtd()} - ${product.GetTotalPrice()}");
        }
        Console.WriteLine();
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine("Shipping Label:");
        Console.WriteLine($"Customer: {_customer.GetName()}");
        Console.WriteLine(_customer.GetAddressText());
        Console.WriteLine();
    }

    public void DisplayTotalPrice()
    {
        double shippingCost = 0;

        if (_customer.LiveUsa())
            shippingCost = 5;
        else
            shippingCost = 35;

        double orderCost = OrderTotalCost() - shippingCost;

        Console.WriteLine($"Order Cost {orderCost}");
        Console.WriteLine($"Shipping: ${shippingCost}");
        Console.WriteLine($"Total Cost: {OrderTotalCost()}");
        Console.WriteLine();

    }
}