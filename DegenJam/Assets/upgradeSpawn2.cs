using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upgradeSpawn2 : MonoBehaviour
{
    public static bool spawnUpgrade = false;
    public bool dropUpgrade = false;
    public GameObject upgrade;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (spawnUpgrade == true)
        {
            Instantiate(upgrade, new Vector3(transform.position.x, transform.position.y), Quaternion.identity);
            spawnUpgrade = false;
        }
    }
}