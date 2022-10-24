using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    int isWalkingHash, isRunningHash, isWalkingBackwardsHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isWalkingBackwardsHash = Animator.StringToHash("isWalkingBackwards");
        isRunningHash = Animator.StringToHash("isRunning");
    }

    // Update is called once per frame
    void Update()
    {
        bool bIsForwardPressed = Input.GetKey(KeyCode.W);
        bool bIsBackwardsPressed = Input.GetKey(KeyCode.S);
        bool bIsRunPressed = Input.GetKey(KeyCode.LeftShift);

        //performance
        bool bIsWalking = animator.GetBool(isWalkingHash);
        bool bIsRunning = animator.GetBool(isRunningHash);
        bool bIsWalkingBackwards = animator.GetBool(isWalkingBackwardsHash);
        
        //de idle a caminar
        if (!bIsWalking && bIsForwardPressed)
        {
            animator.SetBool(isWalkingHash,true);
        }
        //de caminar a idle
        if (bIsWalking && !bIsForwardPressed)
        {
            animator.SetBool(isWalkingHash, false);
        }
        //si no está corriendo, se presiona W y shift izq (para correr)
        if(!bIsRunning && (bIsForwardPressed && bIsRunPressed))
        {
            animator.SetBool(isRunningHash,true);
        }
        //si está corriendo y se deja de caminar (presionar W) o si se deja de correr
        if(bIsRunning && (!bIsForwardPressed || !bIsRunPressed))
        {
            animator.SetBool(isRunningHash, false);
        }

        if (!bIsWalkingBackwards && bIsBackwardsPressed)
        {
            animator.SetBool(isWalkingBackwardsHash,true);
        }
        if (bIsWalkingBackwards && !bIsBackwardsPressed)
        {
            animator.SetBool(isWalkingBackwardsHash, false);
        }
    }
}
