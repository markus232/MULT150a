using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;
    public int numberOfLamps = 10;
    public float spacing = 5.0f;

    void Start()
    {
        for (int i = 0; i < numberOfLamps; i++)
        {
            // Spawns lamps in a line along the X-axis
            Vector3 spawnPosition = new Vector3(i * spacing, 0, 0);
            Instantiate(prefab, spawnPosition, Quaternion.identity);
        }
    }

    void Update()
    {
        // Spawns at 0,0,0 (World Origin)
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }

        // Spawns at the Generator's current position
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}