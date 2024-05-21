using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public float speed, jumpForce, groundCheckRadius;
    private Rigidbody2D rb;
    public Transform groundCheck;
    public LayerMask groundMask;
    public GameManager gameManager;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
    }


    void Movimiento()
    {
        float MoveX = Input.GetAxis("Horizontal");
       
        rb.velocity = new Vector2 (MoveX * speed, rb.velocity.y);

        bool InGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundMask);
        if ((Input.GetKey(KeyCode.Space)) && InGround)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Sierra"))
        {
            gameManager.GameOver();
            Destroy(gameObject);
        }
    }
 
}
