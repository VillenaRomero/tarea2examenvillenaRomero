using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  /* public KeyCode up;
    public KeyCode down;*/
    private Rigidbody2D myRB;
    [SerializeField]
    private float speed;
    private float limitSuperior;
    private float limitInferior;
    private float verticalMovement;
    public float moveSpeed = 5f;
    public int player_lives = 4;
    // Start is called before the first frame update
    void Start()
    {
        /*if (up == KeyCode.None) up = KeyCode.UpArrow;
        if (down == KeyCode.None) down = KeyCode.DownArrow;*/
        myRB = GetComponent<Rigidbody2D>();
        SetMinMax();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(up) && transform.position.y < limitSuperior)
        {
            myRB.velocity = new Vector2(0f, speed);
        }
        else if (Input.GetKey(down) && transform.position.y > limitInferior)
        {
            myRB.velocity = new Vector2(0f, -speed);
        }
        else
        {
            myRB.velocity = Vector2.zero;
        }*/

        MoveVertically();
    }
    private void MoveVertically()
    {
        Vector3 movement = new Vector3(0, verticalMovement, 0) * moveSpeed * Time.deltaTime;
        transform.position += movement;
    }
    
    public void DirectionArribayAbajo(InputAction.CallbackContext context)
    {
        verticalMovement = context.ReadValue<float>();
    }

    void SetMinMax()
    {
        Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        limitInferior = -bounds.y;
        limitSuperior = bounds.y;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Candy")
        {
            CandyGenerator.instance.ManageCandy(other.gameObject.GetComponent<CandyController>(), this);
        }
    }
}
