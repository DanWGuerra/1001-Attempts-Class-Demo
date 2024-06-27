using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float speed, rotationSpeed;
    public Transform player;
    private Rigidbody2D rb;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //if (player != null) 
        //{
        //    Vector2 direccion = (Vector2)player.position - (Vector2)transform.position;
        //    direccion.Normalize();

        //    float cantidadRotacion = Vector3.Cross(direccion, transform.right).z;
        //    rb.angularVelocity = -cantidadRotacion * rotationSpeed;
        //    rb.velocity = transform.right * speed;

        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
