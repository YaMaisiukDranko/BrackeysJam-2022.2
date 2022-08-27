using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator PlayerAnimator;
    public PlayerMovement playerMovement;
    
    public enum MovementStates { WalkUp, WalkDown, WalkLeft, WalkRight, Idle }
    MovementStates state;
    private void Start()
    {
        state = MovementStates.Idle;
    }

    public void UpdateAnimation()
    {
        // up/down
        if (playerMovement.movement.y > 0) //up
        {
            PlayerAnimator.SetTrigger("WalkUp");
        }
        else if (playerMovement.movement.y < 0) //down
        {
            PlayerAnimator.SetTrigger("WalkDown");
        }
        
        // right/left
        if (playerMovement.movement.x > 0) //right
        {
            PlayerAnimator.SetTrigger("WalkRight");
        }
        else if(playerMovement.movement.x < 0) //left
        {
            PlayerAnimator.SetTrigger("WalkLeft");
        }
        
        //idle
        if (playerMovement.movement.x == 0 && playerMovement.movement.y == 0)
        {
            PlayerAnimator.SetTrigger("Idle");
        }
    }
}
