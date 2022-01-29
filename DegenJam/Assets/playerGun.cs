using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerGun : MonoBehaviour
{
    public float reloadTimer = 4f;
    public float reloadSpeed = 4f;

    public int bulletNum = 2;

    public GameObject bullet;

    private float nextFire;
    private float fireRate = 2;



    // Start is called before the first frame update
    void Start()
    {
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
       
        reloadTimer -= Time.deltaTime;
        

        if (Input.GetMouseButtonDown(0))
        {
            if (reloadTimer < 0f)
            {

                Fire();

                reloadTimer = reloadSpeed;

            }
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

  

