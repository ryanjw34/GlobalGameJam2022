using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class waveText : MonoBehaviour
{
    public Text Text1;

    // Start is called before the first frame update
    void Start()
    {
        Text1 = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Text1.text = enemySpawns.waveNumber.ToString();
    }
}
