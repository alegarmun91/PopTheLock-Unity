using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostRunCheck : StateMachineBehaviour
{
    public GameData gameData;
    private static readonly int LostRun = Animator.StringToHash("LostRun");

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(gameData.livesRemaining<=0)
            animator.SetBool(LostRun, true);
    }

    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool(LostRun, false);
    }
}
