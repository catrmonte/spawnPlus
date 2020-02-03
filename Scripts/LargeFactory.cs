using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeFactory : AbstractFactory
{
    public override ILarge GetLarge(LargeType largeType)
    {
        switch (largeType)
        {
            case LargeType.Cabbage:
                ILarge cabbage = new Cabbage();
                return cabbage;
            case LargeType.Pineapple:
                ILarge pineapple = new Pineapple();
                return pineapple;
            case LargeType.Pumpkin:
                ILarge pumpkin = new Pumpkin();
                return pumpkin;
        }
        return null;
    }

    public override IFruit GetFruit(FruitType fruitType)
    {
        return null;
    }

    public override IVeggie GetVeggie(VeggieType veggieType)
    {
        return null;
    }
}
