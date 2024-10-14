using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientodeenemigo : MonoBehaviour
{
    private Rigidbody2D rigibody2d;
    public float speedx;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void Awake()
    {
        rigibody2d = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        rigibody2d.velocity = new Vector2(-speedx , 0);
    }
    public void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            Destroy(this.gameObject);
        }
    }
}
