namespace DesignPatterns.Builder;

public class Director
{
    private IBuilder _builder;

    public Director(IBuilder builder)
    {
        _builder = builder;
    }

    public void BuildMinimalViableProduct()
    {
        _builder.BuildPartA();
    }

    public void BuildFullFeaturedProduct()
    {
        _builder.BuildPartA();
        _builder.BuildPartB();
        _builder.BuildPartC();
    }
}