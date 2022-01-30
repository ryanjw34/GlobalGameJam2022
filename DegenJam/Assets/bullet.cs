using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    Vector3 moveDirection;
    float speed = 5;

    private enemy enemy;
    public static int maxPierce = 2;
    private int pierce = 2;

    private GameObject check;
    private GameObject oldCheck;

    public static Vector3 bulletSize = new Vector3(.0f, .0f, 1);
    public static float size = .5f;


    // Start is called before the first frame update
    void Start()
    {
        moveDirection = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position);
        moveDirection.z = 0;
        moveDirection.Normalize();
        pierce = maxPierce;
        bulletSize = new Vector3(size, size, 1);
        transform.localScale = bulletSize;
    }

    // Update is called once per frame
    void Update()
    {

        if (pierce <= 0)
        {
            Destroy(gameObject);
        }

        transform.position = transform.position + moveDirection * speed * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        check = col.gameObject;
        if (col.gameObject.tag == "wall")
        {
            //wall
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "enemy" && oldCheck != check)
        {

            oldCheck = check;
            pierce = pierce - 1;
        }

    }


}

