using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawns : MonoBehaviour
{
    private float spawnTimer;
    public GameObject enemy1;
    public static int enemycount = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer<=0f)
        {
            if (enemycount <= 300)
            {
                Instantiate(enemy1, new Vector3(transform.position.x, transform.position.y), Quaternion.identity);
                enemycount = enemycount + 1;
                spawnTimer = (Random.Range(3f, 20.0f));
            }
        
        }
        
    }
}
