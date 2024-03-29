﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class advencher : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State gameStart;

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = gameStart;
        textComponent.text = state.GetStateStory();

    }

    // Update is called once per frame
    void Update()
    {
        manageState();
    }

    private void manageState()
    {
        var nextStates = state.GetNextStates();
        for (int index = 0; index < nextStates.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                state = nextStates[index];
            }
        }
        textComponent.text = state.GetStateStory();
    }
       
}
