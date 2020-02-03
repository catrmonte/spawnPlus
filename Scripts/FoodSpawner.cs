using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodSpawner : MonoBehaviour
{
    // Fruits
    private IFruit m_Apple;
    private IFruit m_Banana;
    private IFruit m_Avocado;

    // Veggies
    private IVeggie m_Carrot;
    private IVeggie m_Broccoli;
    private IVeggie m_Potato;

    // Large
    private ILarge m_Cabbage;
    private ILarge m_Pineapple;
    private ILarge m_Pumpkin;

    public Text outputText;

    public GameObject applePrefab;
    public GameObject bananaPrefab;
    public GameObject avocadoPrefab;
    public GameObject carrotPrefab;
    public GameObject potatoPrefab;
    public GameObject broccoliPrefab;
    public GameObject cabbagePrefab;
    public GameObject pineapplePrefab;
    public GameObject pumpkinPrefab;

    private AbstractFactory factory;

    public void SpawnFruit(ProduceRequirements requirements)
    {

        factory = FactoryProducer.GetFactory(FactoryType.Fruit);

        if (requirements.green) // If it is a green fruit, spawn an avocado
        {
            GameObject produce = Instantiate(avocadoPrefab);

            outputText.text = "Created an avocado.";

            m_Avocado = factory.GetFruit(FruitType.Avocado);
            m_Avocado.Fruitify();
        }
        else if (requirements.yellow) // if it is a yellow fruit, spawn a banana
        {
            GameObject produce = Instantiate(bananaPrefab);

            outputText.text = "Created a banana.";

            m_Banana = factory.GetFruit(FruitType.Banana);
            m_Banana.Fruitify();
        }
        else if (requirements == null) // if no requirements are given, spawn all fruits
        // This is for the case when the user presses the fruit key
        {
            m_Apple = factory.GetFruit(FruitType.Apple);
            m_Banana = factory.GetFruit(FruitType.Banana);
            m_Avocado = factory.GetFruit(FruitType.Avocado);

            m_Apple.Fruitify();
            m_Banana.Fruitify();
            m_Avocado.Fruitify();
        }
        else // Otherwise spawn an apple
        {
            GameObject produce = Instantiate(applePrefab);

            outputText.text = "Created an apple.";

            m_Apple = factory.GetFruit(FruitType.Apple);
            m_Apple.Fruitify();
        }
        
    }

    public void SpawnVeggies(ProduceRequirements requirements)
    {
        factory = FactoryProducer.GetFactory(FactoryType.Veggie);

        if (requirements.green) // If it's a green vegetable, spawn Broccoli
        {
            GameObject produce = Instantiate(broccoliPrefab);

            outputText.text = "Created broccoli.";

            m_Broccoli = factory.GetVeggie(VeggieType.Broccoli);
            m_Broccoli.Vegetate();
        }
        else if (requirements.yellow) // If it's a yellow vegetable, spawn a Potato
        {
            GameObject produce = Instantiate(potatoPrefab);

            outputText.text = "Created a potato.";

            m_Potato = factory.GetVeggie(VeggieType.Potato);
            m_Potato.Vegetate();
        }
        else if (requirements == null) // if no requirements are given, spawn all vegetables
        //This is the case for when the user presses the vegetable key
        {
            m_Carrot = factory.GetVeggie(VeggieType.Carrot);
            m_Broccoli = factory.GetVeggie(VeggieType.Broccoli);
            m_Potato = factory.GetVeggie(VeggieType.Potato);

            m_Carrot.Vegetate();
            m_Broccoli.Vegetate();
            m_Potato.Vegetate();
        }
        else // Otherwise spawn a carrot
        {
            GameObject produce = Instantiate(carrotPrefab);

            outputText.text = "Created a carrot.";

            m_Carrot = factory.GetVeggie(VeggieType.Carrot);
            m_Carrot.Vegetate();
        }
    }

    public void SpawnLarge(ProduceRequirements requirements)
    {
        factory = FactoryProducer.GetFactory(FactoryType.Large);

        if (requirements.green) {
            GameObject produce = Instantiate(cabbagePrefab);

            outputText.text = "Created cabbage.";

            m_Cabbage = factory.GetLarge(LargeType.Cabbage);
            m_Cabbage.Enlarge();
        }
        else if (requirements.yellow)
        {
            GameObject produce = Instantiate(pineapplePrefab);

            outputText.text = "Created a pineapple.";

            m_Pineapple = factory.GetLarge(LargeType.Pineapple);
            m_Pineapple.Enlarge();
        }
        else
        {
            GameObject produce = Instantiate(pumpkinPrefab);

            outputText.text = "Created a pumpkin.";

            m_Pumpkin = factory.GetLarge(LargeType.Pumpkin);
            m_Pumpkin.Enlarge();
        }
    }
}
