using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerGun : MonoBehaviour
{
    public GameObject bullet;

    private float nextFire;
    public static float fireRate = 2;

    //public int bulletNum = 2;

    // Start is called before the first frame update
    void Start()
    {
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {                   
        if (Input.GetMouseButtonDown(0))
        {    
            Fire();       
        }
    }


    void Fire()
    {
        if (Time.time > nextFire)
        {
            Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }


}

  

