using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_damage : MonoBehaviour
{
    
    [Range(1,10)]
    [SerializeField] private float speed = 10f;
    
    [Range(1,10)]
    [SerializeField] private float lifeTime = 3f;
    
    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, lifeTime);
    }

    ///*
    private void FixedUpdate(){
        rb.velocity = transform.up * speed;
    }
    // */
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<enemy>() != null){
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
