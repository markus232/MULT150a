using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class OiiaCat : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("GAME OVER \n L in the chat");
            EditorApplication.isPlaying = false;
        }
    }
}