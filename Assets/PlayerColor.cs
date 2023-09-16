using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColor : MonoBehaviour
{
    private GameObject Player;

    private new SpriteRenderer renderer;
    public Color startColor,endColor;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        renderer = Player.GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
        renderer.color = Color.Lerp(startColor,endColor, Mathf.PingPong(Time.time * speed, 1.0f));
    }
}
