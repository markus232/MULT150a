using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaosGoalScript : MonoBehaviour
{
    public bool isSolved = false;
    private int ballsCollected = 0;
    public int totalBallsRequired = 5;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == gameObject.tag)
        {
            ballsCollected++;
            Destroy(collider.gameObject);

            if (ballsCollected >= totalBallsRequired)
            {
                isSolved = true;

                if (GetComponent<Light>() != null)
                {
                    GetComponent<Light>().enabled = false;
                }
                Debug.Log("Puzzle Solved! All 5 balls collected.");
            }
        }
    }
}