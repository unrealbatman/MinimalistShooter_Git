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



    // Start is called before the first frame update
    void Start()
    {
        Enemies = new ArrayList();
        StartCoroutine(spawnEnemy(square_Interval, Enemy_Square));
        StartCoroutine(spawnEnemy(triangle_Interval, Enemy_Triangle));
    }


    IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        while (true)
        {

            GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-9, 9), Random.Range(-4f, 4f), 11.72956f), Quaternion.identity);
            Enemies.Add(newEnemy);

            if (Enemies.Count >= 2)
            {
                Debug.Log("HEre");
                yield return new WaitForSeconds(interval);
            }
        }



    }



}
