using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    int isWalkingHash, isRunningHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
    }

    // Update is called once per frame
    void Update()
    {
        bool bIsForwardPressed = Input.GetKey(KeyCode.W);
        bool bIsRunPressed = Input.GetKey(KeyCode.LeftShift);

        //performance
        bool bIsWalking = animator.GetBool(isWalkingHash);
        bool bIsRunning = animator.GetBool(isRunningHash);
        

        if (!bIsWalking && bIsForwardPressed)
        {
            animator.SetBool(isWalkingHash,true);
        }

        if (bIsWalking && !bIsForwardPressed)
        {
            animator.SetBool(isWalkingHash, false);
        }

        if(!bIsRunning && (bIsForwardPressed && bIsRunPressed))
        {
            animator.SetBool(isRunningHash,true);
        }

        if(bIsRunning && (!bIsForwardPressed || !bIsRunPressed))
        {
            animator.SetBool(isRunningHash, false);
        }
    }
}
