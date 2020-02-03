using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    public FoodSpawner m_SpawnerFood;
    public Text outputText; 

    public bool large;
    public bool fruit; // if not fruit, vegetable
    public bool green; // first will check if it's green
    public bool yellow; // if not green, will check if yellow
    ProduceRequirements requirements = new ProduceRequirements();

    public void Start()
    {
        
        requirements.green = green;
        requirements.yellow = yellow;
    }

    public void callSpawn()
    {
        
        if (requirements.fruit) // fruit is a requirement
        {
            m_SpawnerFood.SpawnFruit(requirements);
        }
        else if (requirements.large) // if not a fruit, then a large produce
        {
            m_SpawnerFood.SpawnLarge(requirements);
        }
        else // if not a fruit or a "large", it will be a vegetable
        {
            m_SpawnerFood.SpawnVeggies(requirements);
        }
    }

    public void ToggleFruit()
    {
        requirements.fruit = !requirements.fruit;
        if (requirements.fruit)
        {
            outputText.text = "Fruit Enabled.";
        } 
        else
        {
            outputText.text = "Fruit Disabled.";
        }
    }

    public void ToggleLarge()
    {
        requirements.large = !requirements.large;
        if (requirements.large)
        {
            outputText.text = "Large Enabled.";
        }
        else
        {
            outputText.text = "Large Disabled.";
        }
    }

    public void ToggleGreen()
    {
        requirements.green = !requirements.green;
        if (requirements.green)
        {
            outputText.text = "Green Enabled.";
        }
        else
        {
            outputText.text = "Green Disabled.";
        }
    }

    public void ToggleYellow()
    {
        requirements.yellow = !requirements.yellow;
        if (requirements.yellow)
        {
            outputText.text = "Yellow Enabled.";
        }
        else
        {
            outputText.text = "Yellow Disabled.";
        }
    }
}
