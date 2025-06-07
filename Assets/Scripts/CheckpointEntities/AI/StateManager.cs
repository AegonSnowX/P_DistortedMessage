using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;
using UnityEngine.InputSystem.XR.Haptics;

public abstract class StateManager<EState> : MonoBehaviour where EState : Enum
{
    protected Dictionary <EState, BaseState<EState>> States = new Dictionary<EState, BaseState<EState>>(); //holds all possible states mapped by type
    
    protected BaseState<EState> CurrentState;
    
    protected bool isTransitioningState = false;

    void Start()
    {
        CurrentState.EnterState(); // to sync the state with the start of monobehvior
    }

    void Update()
    {
        EState nextStateKey = CurrentState.GetNextState(); // ask current state what it wants to do next

        if (!isTransitioningState && nextStateKey.Equals(CurrentState.StateKey))
        {
            CurrentState.UpdateState(); // if same state? just keep updating
        }
        else if (!isTransitioningState)
        {
            TransitionToState(nextStateKey); // if time to switch pass control to the next one
        }
        
        CurrentState.UpdateState();
    }

    public void TransitionToState(EState stateKey)
    {
        isTransitioningState = true;
        CurrentState.ExitState(); // it exits current state
        CurrentState = States[stateKey]; // changes current state with state key
        CurrentState.EnterState(); // enters new state
        isTransitioningState = false;
    }

    void OnTriggerEnter(Collider other)
    {
        CurrentState.OnTriggerEnter(other);
    }

    void OnTriggerStay(Collider other)
    {
        CurrentState.OnTriggerStay(other);
    }

    void OntriggerExit(Collider other)
    {
        CurrentState.OnTriggerExit(other);
    }
}
