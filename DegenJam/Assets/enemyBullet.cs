using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBullet : MonoBehaviour
{
    private float speed = 5f;

    Rigidbody2D rb;

    private GameObject target;


    private GameObject check;
    private GameObject oldCheck;

    private Vector2 moveDirection;

   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("player");
        moveDirection = (target.transform.position - transform.position).normalized * speed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.FindGameObjectWithTag("player");
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        check = col.gameObject;

        if (col.gameObject.tag == "player")
        {
            Debug.Log("Player Hit");
            Destroy(gameObject);
            oldCheck = check;
        }
        if (col.gameObject.tag == "wall")
        {
            Destroy(gameObject);
        }

    }
}
