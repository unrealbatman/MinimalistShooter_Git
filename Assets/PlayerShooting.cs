using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform firingPoint;
    [Range(0.1f, 1f)]
    [SerializeField] float fireRate = 0.5f;
    
    //sound
    public AudioSource AudioSource;
    public AudioClip shootingClip;
    
    float fireTimer;
    
    
    void Update(){
        if (Input.GetMouseButtonDown(0) && fireTimer <= 0f){
            Shoot();
            fireTimer = fireRate;
        } else {
            fireTimer -= Time.deltaTime;
        }
    }
    
    void Shoot(){
        AudioSource.PlayOneShot(shootingClip);
        Instantiate(bullet, firingPoint.position, firingPoint.rotation);
    }
}
