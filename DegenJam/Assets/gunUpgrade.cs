using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunUpgrade : MonoBehaviour
{
    private int upgradeNum;
    public static string upgradeText="";
    private GameObject Player;
 
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("player");
        upgradeNum =Random.Range(1, 4);
        Debug.Log(upgradeNum);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, Player.transform.position) < 5)
        {
            Debug.Log("close");
            if (upgradeNum == 1)
            {
                upgradeText = "Faster Reload Speed";
            }
            else if(upgradeNum == 2)
            {
                upgradeText = "Upgrade 2";
            }
            else if (upgradeNum == 3)
            {
                upgradeText = "Upgrade 3";
            }
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {
            if (upgradeNum == 1)
            {
                playerGun.fireRate = playerGun.fireRate - 1;
            }
            else if (upgradeNum == 2)
            {
                upgradeText = "Upgrade 2";
            }
            else if (upgradeNum == 3)
            {
                upgradeText = "Upgrade 3";
            }

        }
   

    }





}