using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField]
    ArrayList Enemies ;

    [SerializeField]
    private GameObject Enemy_Square;

    [SerializeField]
    private  GameObject Enemy_Triangle;

    [SerializeField]
    private float square_Interval;
    [SerializeField]
    private float triangle_Interval;

    private BoxCollider2D square_collider;
    private PolygonCollider2D triangle_collider;

    // Start is called before the first frame update
    void Start()
    {
        Enemies = new ArrayList();
        StartCoroutine(spawnEnemy(square_Interval, Enemy_Square));
        StartCoroutine(spawnEnemy(triangle_Interval, Enemy_Triangle));
        square_collider = Enemy_Square.GetComponent<BoxCollider2D>();
        triangle_collider = Enemy_Triangle.GetComponent<PolygonCollider2D>();
        if(square_collider.gameObject.tag =="bullet" ) {
            StartCoroutine(DespawnEnemy(square_collider.gameObject));
            Debug.Log("HER");
        }
        else if (triangle_collider.gameObject.tag == "bullet")
        {
            StartCoroutine(DespawnEnemy(triangle_collider.gameObject));

        }
    }


    IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-10, 10), Random.Range(-4.5f,4.5f),11.72956f),Quaternion.identity);
        Enemies.Add(newEnemy);
        StartCoroutine(spawnEnemy(interval,enemy));
        if(Enemies.Count >= 5)
        {
            StopAllCoroutines();
        }
    }
    IEnumerator DespawnEnemy(GameObject enemy)
    {
        yield return new WaitForSeconds(1.0f);
        Destroy(enemy);
        Enemies.Remove(enemy);
    }


}
