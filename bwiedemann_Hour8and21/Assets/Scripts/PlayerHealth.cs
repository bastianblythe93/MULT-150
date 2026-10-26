using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    int healthpoints = 3992;
    void Start()
    {
      healthpoints = UsePotions(healthpoints);
        Debug.Log(healthpoints);
        healthpoints = UsePotions(healthpoints);
        Debug.Log(healthpoints);
        healthpoints = UsePotions(healthpoints);
        Debug.Log(healthpoints);
        healthpoints = UsePotions(healthpoints);
        Debug.Log(healthpoints);
    }

    void Update()
    {
        
    }

    int UsePotions (int health)
    {
        int result;
        result = health + 400;
        return result;
    }
}
