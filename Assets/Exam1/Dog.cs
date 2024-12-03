using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    private float dailyFoodConsumption = 0;
    private int activityLevel;
    private void Start()
    {
        Init("Dog");
        CalculateFoodRequirement();
    }




    public override float CalculateFoodRequirement()
    {
        Debug.Log($"{animalName}"); 

    }
}
