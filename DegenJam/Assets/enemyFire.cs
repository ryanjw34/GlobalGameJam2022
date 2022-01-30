using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFire : MonoBehaviour
{
    public GameObject bullet;
    private GameObject target;
    private float fireRate = 3;
    private float nextFire;

    // Start is called before the first frame update
    void Start()
    {
        nextFire = Time.time;

    }

    // Update is called once per frame
    void Update()
    {

        target = GameObject.FindGameObjectWithTag("player");
        if (target != null)
        {
            Fire();
            fireRate = (Random.Range(.5f, 4f)); 
        }
    }
    void Fire()
    {
        if (Time.time > nextFire)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }
}
