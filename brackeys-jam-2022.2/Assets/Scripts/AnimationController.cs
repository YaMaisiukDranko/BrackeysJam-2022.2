using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator PlayerLegsAnimator;
    public SpriteRenderer PlayerTorso;
    public PlayerMovement playerMovement;
    public Vector2 playerMovementStates;
    
    public enum MovementStates { WalkUp, WalkDown, WalkLeft, WalkRight, Idle }
    MovementStates state;
    private void Start()
    {
        state = MovementStates.Idle;
    }

    private void Update()
    {
        UpdateAnimation();
        playerMovementStates = playerMovement.movement;
    }

    public void UpdateAnimation()
    {
        // up/down
        if (playerMovement.movement.y > 0) //up
        {
            PlayerLegsAnimator.SetTrigger("WalkUp");
        }
        else if (playerMovement.movement.y < 0) //down
        {
            PlayerLegsAnimator.SetTrigger("WalkDown");
        }
        
        // right/left
        if (playerMovement.movement.x > 0) //right
        {
            PlayerLegsAnimator.SetTrigger("WalkRight");
        }
        else if(playerMovement.movement.x < 0) //left
        {
            PlayerLegsAnimator.SetTrigger("WalkLeft");
        }
        
        //idle
        if (playerMovement.movement.x == 0 && playerMovement.movement.y == 0)
        {
            PlayerLegsAnimator.ResetTrigger("WalkUp");
            PlayerLegsAnimator.ResetTrigger("WalkDown");
            PlayerLegsAnimator.ResetTrigger("WalkRight");
            PlayerLegsAnimator.ResetTrigger("WalkLeft");
            PlayerLegsAnimator.SetTrigger("Idle");
        }

        if (playerMovement.movement.x != 0 && playerMovement.movement.y != 0)
        {
            PlayerLegsAnimator.ResetTrigger("Idle");
        }
    }
}
