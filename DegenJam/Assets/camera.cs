using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset=new Vector3 (0,0,0);

    void Update()
    {
        transform.position = new Vector3(player.transform.position.x + offset.x, player.transform.position.y + offset.y); // Camera follows the player with specified offset position
    }
}
