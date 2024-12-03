using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal
{
    private float dailyFoodConsumption = 0.5f;
    private float weight = 0.1f;
    private void Start()
    {
        Init("Bird");
        CalculateFoodRequirement();
        MakeSound();
    }

    public override float CalculateFoodRequirement()
    {
        float foodCon = dailyFoodConsumption * weight * 7;
        Debug.Log($"{animalName} eats {dailyFoodConsumption} daily with activity level {weight}");
        Debug.Log($"{animalName} weekly food req {foodCon}");
        return foodCon;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
