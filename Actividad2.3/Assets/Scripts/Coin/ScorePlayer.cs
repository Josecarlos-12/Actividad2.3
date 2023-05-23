using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int pointValue = 10;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {

            ScorePlayer playerScore = other.GetComponent<ScorePlayer>();
            if (playerScore != null)
            {
                playerScore.AddPoints(pointValue);
            }


            Destroy(gameObject);
        }
    }
}
