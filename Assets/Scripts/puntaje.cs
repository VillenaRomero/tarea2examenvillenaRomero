using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class puntaje : MonoBehaviour
{
    public TextMeshPro textpoints;
    public int points;
    // Start is called before the first frame update
    void Start()
    {
        IncreasePoitns(0);
    }
    public void IncreasePoitns(int pointsToAdd)
    {
        points = points + pointsToAdd;
        textpoints.text = "Puntos: " + points;

    }
}
