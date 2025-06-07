using UnityEngine;

public class AIStateMachine : StateManager<AIStateMachine.AIState>
{
   public enum AIState
   {
      Emerging, 
      Fleeing,
      UnderArrest,
   }

   void Awake()
   {
      CurrentState = States[AIState.Emerging];
   }
}
