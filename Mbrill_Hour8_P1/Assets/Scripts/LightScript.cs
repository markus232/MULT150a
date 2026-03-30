using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    private Light targetLightbulb;
    // Start is called before the first frame update
    void Start()
    {
        targetLightbulb = GetComponent<Light>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            targetLightbulb.enabled = !targetLightbulb.enabled;
        }
    }
}
