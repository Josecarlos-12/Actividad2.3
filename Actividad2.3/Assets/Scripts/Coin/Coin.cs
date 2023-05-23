using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePlayer : MonoBehaviour
{
    public int score = 0;

    // Agregar puntos al puntaje del jugador
    public void AddPoints(int points)
    {
        score += points;
        Debug.Log("Puntos agregados: " + points);
        Debug.Log("Puntaje total: " + score);
    }
}
