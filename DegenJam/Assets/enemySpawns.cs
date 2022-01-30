using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawns : MonoBehaviour
{
    private float spawnTimer;
    public GameObject enemy1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer<=0f)
        {
            Instantiate(enemy1, new Vector3(transform.position.x, transform.position.y), Quaternion.identity);
            spawnTimer = (Random.Range(3f, 20.0f));
        }
        
    }
}
