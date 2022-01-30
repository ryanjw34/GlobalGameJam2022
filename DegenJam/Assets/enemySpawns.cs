using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawns : MonoBehaviour
{
    private float spawnTimer;
    public GameObject enemy1;
    public static int enemycount = 0;
    public static int killcount=0;
    public static int waveAmount = 10;
    public static int spawncount = 0;
    public static bool pauseSpawn = false;
    public static int waveNumber = 1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer<=0f)
        {
            if (enemycount <= 300 && pauseSpawn == false && spawncount<waveAmount)
            {   
                Instantiate(enemy1, new Vector3(transform.position.x, transform.position.y), Quaternion.identity);
                enemycount = enemycount + 1;
                spawncount = spawncount + 1;
                spawnTimer = (Random.Range(3f, 20.0f));
            }
        
        }

        if (killcount >= waveAmount)
        {
            pauseSpawn = true;
            killcount = 0;
            upgradeSpawn.spawnUpgrade = true;
            upgradeSpawn2.spawnUpgrade = true;
            spawncount = 0;
            waveAmount = waveAmount * 2;
            waveNumber = waveNumber + 1;
        }
        
    }
}
