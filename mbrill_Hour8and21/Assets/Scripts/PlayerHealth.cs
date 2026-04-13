using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    int healthpoints = 3992;

    void Start()
    {
        Debug.Log(healthpoints);

        healthpoints = UsePotion(healthpoints);
        Debug.Log(healthpoints);

        healthpoints = UsePotion(healthpoints);
        Debug.Log(healthpoints);

        healthpoints = UsePotion(healthpoints);
        Debug.Log(healthpoints);

        healthpoints = UsePotion(healthpoints);
        Debug.Log(healthpoints);
    }

    void Update()
    {

    }

    int UsePotion(int health)
    {
        return health + 400;
    }
}
