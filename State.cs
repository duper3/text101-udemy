using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
// scrip
{
    [TextArea(10, 20)] [SerializeField] string storytext;
    [SerializeField] State[] nextStates;

    public string GetStateStory()
    {
        return storytext;
    }
    
    public State[] GetNextStates()
    {
       return nextStates;
    }
    
}


