using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    // SerializeField pus intre paranteze patrate este folosit pentru a fi vizibil din Inspector
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;


    private string[] daysOfTheWeek = { "Monday", "Wednessday", "Tuesday", "Thursday", "Friday", "Saturday", "Sunday" };
    private State state;
    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
        Debug.Log(daysOfTheWeek[4]);
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextstate = state.getNextStates();
        
        for(int i = 0; i < nextstate.Length; i++)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                state = nextstate[i];
            }
        }
        textComponent.text = state.GetStateStory();
    }
}
