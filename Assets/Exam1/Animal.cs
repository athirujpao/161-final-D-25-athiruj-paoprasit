using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string animalName;
    public string AnimalName {  get { return animalName; } }

    //method
    public void Init(string newName)
    {
        newName = animalName;
    }
    public abstract float CalculateFoodRequirement();
    
        
    
    public virtual void MakeSound() 
    {

        Debug.Log($"The animal make a sound");
        
    }
    public void DisplayName() 
    {
        Debug.Log($"This is {animalName}");
    }
}
