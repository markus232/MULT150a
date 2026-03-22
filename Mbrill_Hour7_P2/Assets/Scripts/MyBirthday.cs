using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int count = 1;

        while (count <= 30)
        {
            if (count == 24)
            {
                print("Its my birthday!");
            }
            else
            {
                Debug.Log(count);
            }
            count++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}