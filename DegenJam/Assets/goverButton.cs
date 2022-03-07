using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class goverButton : MonoBehaviour
{
    public Button myButton;


    // Start is called before the first frame update
    void Start()
    {
        Button goverBut = myButton.GetComponent<Button>();
        goverBut.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    public void TaskOnClick()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
