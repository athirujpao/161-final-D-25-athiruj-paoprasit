using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    private float dailyFoodConsumption = 0.5f;
    private int activityLevel = 3;
    private void Start()
    {
        Init("Dog");
        CalculateFoodRequirement();
        MakeSound();
    }

    


    public override float CalculateFoodRequirement()
    {
        float foodCon = dailyFoodConsumption * activityLevel * 7;
        Debug.Log($"{AnimalName} eats {dailyFoodConsumption} daily with activity level {activityLevel}");
        Debug.Log($"{animalName} weekly food req {foodCon}");
        return foodCon;
    }


}
