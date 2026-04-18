using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        print("Entered: " + gameObject.name);
    }

    void OnTriggerExit(Collider other)
    {
        print("Exited: " + gameObject.name);
    }

    void OnTriggerStay(Collider other)
    {
        print("Inside: " + gameObject.name);
    }
}
