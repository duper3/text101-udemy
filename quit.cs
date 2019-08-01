using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class quit : MonoBehaviour
{
    public Button ButtenQuit;
    public Button Restart;
    [SerializeField] Text textComponent;
    [SerializeField] State gameStart;

    State state;

    public object bank { get; private set; }

    void Start()
    {
        ButtenQuit.onClick.AddListener(() => buttenquit());
        Restart.onClick.AddListener(() => restart());
    }

    void Update()
    {
        KeyQuit();
        //restart();
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

    public void restart()
    {
        Debug.Log("restart button press");
        
        
    }

    /*
     * buttenquit(State state)
    {
           private void restart(State state)
       {
               if (Input.GetButtonDown(string Restart))
               {
                   Debug.Log("restart button press");

                   state = gameStart;
                   textComponent.text = state.GetStateStory();

               }


                       Debug.Log("restart button press");

                       state = gameStart;
                       textComponent.text = state.GetStateStory();

                       Debug.Log("get GetNextStates ");

                       var nextStates = state.GetNextStates();
                       state = nextStates[0];
                       textComponent.text = state.GetStateStory();
                       Debug.Log("get nextStates " + nextStates);

           }
            */



}

