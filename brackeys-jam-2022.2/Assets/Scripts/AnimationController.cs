using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator PlayerAnimator;
    public PlayerMovement playerMovement;
    public enum MovementStates { WalkUp, WalkDown, WalkLeft, WalkRight, Idle }

    private void Start()
    {
        
    }

    public void UpdateAnimation()
    {
        MovementStates state;
        // up/down
        if (playerMovement.movement.y > 0) //up
        {
            
        }
        else if (playerMovement.movement.y < 0) //down
        {
            
        }
        
        // right/left
        if (playerMovement.movement.x > 0) //right
        {
            
        }
        else if(playerMovement.movement.x < 0) //left
        {
            
        }
        
        //idle
        if (playerMovement.movement.x == 0 && playerMovement.movement.y == 0)
        {
            
        }
    }
}
