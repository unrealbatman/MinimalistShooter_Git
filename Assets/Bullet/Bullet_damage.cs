using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_damage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<enemy>() != null){
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
