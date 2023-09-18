using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Range(1, 10)]
    [SerializeField] float speed = 10f;

    [Range(1, 10)]
    [SerializeField] float lifeTime = 3f;

    private Rigidbody2D rb;



    void Start() {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, lifeTime);
    }

    void FixedUpdate(){
        rb.velocity = transform.up * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Square")||collision.CompareTag("Triangle"))
        {

            Destroy(collision.gameObject);

        }

    }
}
