using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodData : MonoBehaviour
{
    [Tooltip("How many bites it takes to finish this food")]
    public int bitesRemaining = 3;
    
    [Tooltip("Optional: Shrink the food with each bite")]
    public bool shrinkPerBite = true;

    public void TakeBite()
    {
        bitesRemaining--;
        
        if (shrinkPerBite && bitesRemaining > 0)
        {
            // Shrink the food object by 25% each bite
            transform.localScale *= 0.75f; 
        }
    }
}