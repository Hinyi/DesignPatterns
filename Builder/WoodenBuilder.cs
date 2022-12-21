namespace DesignPatterns.Builder;

public class WoodenBuilder : IBuilder
{
    private Product _product = new();

    public WoodenBuilder()
    {
        Reset();
    }

    public void Reset()
    {
        _product = new Product();
    }

    public void BuildPartA()
    {
        _product.Add("PartA111");
    }

    public void BuildPartB()
    {
        _product.Add("PartB111");
    }

    public void BuildPartC()
    {
        _product.Add("PartC111");
    }

    public Product GetProduct()
    {
        var result = _product;
        Reset();

        return result;
    }
}