using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckLostRun : StateMachineBehaviour
{
    public GameData gameData;
    private static readonly int LostRun = Animator.StringToHash("LostRun");

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(gameData.livesRemaining <= 0)
            animator.SetBool(LostRun, true);
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool(LostRun, false);
    }
}
