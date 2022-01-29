using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    Vector3 moveDirection;
    float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        moveDirection = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position);
        moveDirection.z = 0;
        moveDirection.Normalize();
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = transform.position + moveDirection * speed * Time.deltaTime;
    }

}
