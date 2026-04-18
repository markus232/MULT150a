using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    private int collisionCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Sphere")
        {
            collisionCount++;
            Debug.Log("Bounce count: " + collisionCount);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
