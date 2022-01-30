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

    private bool shot = true;



    // Start is called before the first frame update
    void Start()
    {
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
       
        reloadTimer -= Time.deltaTime;

        if (reloadTimer < 0f)
        {
            shot = true;
        }

            if (Input.GetMouseButtonDown(0))
            {
          
                if (shot==true)
                {
                    Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
                    reloadTimer = reloadSpeed;
                    shot = false;
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

  

