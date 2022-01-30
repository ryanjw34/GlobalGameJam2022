using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSword : MonoBehaviour
{
    private bool swordSwinging;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        swordSwinging = false;
        anim = GetComponent<Animator>();
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
            anim.SetTrigger("Attack");
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "enemy")
        {
            if (swordSwinging == true)
            {
                Destroy(col.gameObject);
                swordSwinging = false;

            }
            
            if (swordSwinging == false)
            {
                return;
            }
        }
    }
}
