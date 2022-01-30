using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSword : MonoBehaviour
{
    private bool swordSwinging;
    public Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        swordSwinging = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (swordSwinging == false)
        {
            
        }
        if (Input.GetMouseButtonDown(1))
        {
            swordSwinging = true;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "enemy")
        {
            if (swordSwinging == true)
            {
                Destroy(col.gameObject);

            }
            
            if (swordSwinging == false)
            {
                return;
            }
        }
    }
}
