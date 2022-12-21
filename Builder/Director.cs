﻿namespace DesignPatterns.Builder;

public class Director
{
    private IBuilder _builder;

    public Director(IBuilder builder)
    {
        _builder = builder;
    }
    
    public void BuildMinimalViableProduct()
    {
        this._builder.BuildPartA();
    }
        
    public void BuildFullFeaturedProduct()
    {
        this._builder.BuildPartA();
        this._builder.BuildPartB();
        this._builder.BuildPartC();
    }
}