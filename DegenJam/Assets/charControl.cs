using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charControl : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;

    public SpriteRenderer sprite;

    public float runSpeed = 12.0f;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);

        if (horizontal > 0)
        {
            sprite.flipX=false;
        }
        else if(horizontal < 0)
        {
            sprite.flipX = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "enemy")
        {
            Debug.Log("ene hit");
           
        }
        if (collision.tag == "gunUpgrade")
        {
            Debug.Log("upgrade");
        }

    }

}
