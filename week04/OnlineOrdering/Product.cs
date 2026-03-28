
public class Product
{
    private string _productName;
    private int _id;
    private double _price;
    private int _quant;

    public Product(string name, int id, double price)
    {
        _productName = name;
        _id = id;
        _price = price;
        _quant = 1;
    }

    public double GetTotalPrice()
    {
        double price = _price * _quant;
        return price;
    }

    public string GetProdName()
    {
        string name = _productName;
        return name;
    }

    public int GetProdID()
    {
        int id = _id;
        return id;

    }

    public int GetProdQtd()
    {
        int qtd = _quant;
        return qtd;

    }

    public void SetQuantity(int quant)
    {
        _quant = quant;
    }


}