using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour { 
    public Button myButton;


    // Start is called before the first frame update
    void Start()
    {
        Button startBut = myButton.GetComponent<Button>();
        startBut.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    public void TaskOnClick()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
