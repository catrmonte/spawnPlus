public abstract class AbstractFactory
{
    public abstract IFruit GetFruit(FruitType fruitType);
    public abstract IVeggie GetVeggie(VeggieType veggieType);
    public abstract ILarge GetLarge(LargeType largeType);
}
