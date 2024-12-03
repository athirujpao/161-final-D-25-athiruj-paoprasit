using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public virtual void Cast() 
    {
        Debug.Log($"Casting a generic spell");
    }

    public void Cast(string nameSpell) 
    { 
        
    }
    private void Start()
    {
        Debug.Log("Spell-casting sim start!");
    }
}
