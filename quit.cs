using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quit : MonoBehaviour
{

    public Button ButtenQuit;
    void Start()
    {
     ButtenQuit.onClick.AddListener(() => buttenquit());
     
    }

    void Update()
    {
        KeyQuit();
    }

    private void buttenquit()
    {
        Application.Quit();
        //Debug.Log("press butten quit");
    }
    public void KeyQuit()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            //Debug.Log("Escape press game closing");
        }
    }
}

