using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject Player;
    public Transform target;//set target from inspector instead of looking in Update
    private float speed = 3f;
    private int hp = 2;

    private GameObject check;
    private GameObject oldCheck;
    // Start is called before the first frame update
    void Start()
    {
        speed = (Random.Range(3, 6));
        Player = GameObject.FindGameObjectWithTag("player");
    }

    // Update is called once per frame
    void Update()
    {
        target = Player.transform;
        transform.LookAt(target.position);
        transform.Rotate(new Vector3(0, -90, 0), Space.Self);
        if (Vector3.Distance(transform.position, target.position) > 1f)
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }

        if (hp <= 0)
        {
            enemySpawns.killcount = enemySpawns.killcount+1;        
            Destroy(transform.parent.gameObject);
             
           // Destroy(gameObject);
        }

    }


    void OnTriggerEnter2D(Collider2D col)
    {
        check = col.gameObject;
        if (col.gameObject.tag == "bullet" && oldCheck != check)
        {
            oldCheck = check;
            hp = hp - 1;
        }
    }


}
