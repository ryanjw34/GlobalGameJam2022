using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerGun : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        }
    }

  
}
