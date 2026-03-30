using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float MouseXInput = Input.GetAxis("Mouse X");
        float MouseYInput = Input.GetAxis("Mouse Y");

        Vector3 translation = new Vector3(MouseXInput, MouseYInput, 0);

        transform.Translate(translation);
        
    }
}
