using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crearenemigo : MonoBehaviour
{
    public GameObject prefabEnemy;
    public float minXposition;
    public float maxXposition;
    public float yPosition;
    public puntaje gamemanager;
    private void Start()
    {
        Createenemy();
    }
    void Createenemy()
    {
        float xposition = Random.Range(minXposition, maxXposition);
        Vector2 positioncreate = new Vector2(xposition, yPosition);
        GameObject moneda = Instantiate(prefabEnemy, positioncreate, transform.rotation);
        //moneda.GetComponent<enemigo>().SetEnemyconteiner(this);
        Invoke("Createenemy", 1.0f);
    }
    public void IncreasePoitns(int pointsToAdd)
    {
        gamemanager.IncreasePoitns(pointsToAdd);
    }
}
