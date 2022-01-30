using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controlla : MonoBehaviour
{
    public Button QButton;


    // Start is called before the first frame update
    void Start()
    {
        Button quitBut = QButton.GetComponent<Button>();
        quitBut.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    public void TaskOnClick()
    {
        Application.Quit();
    }
}
