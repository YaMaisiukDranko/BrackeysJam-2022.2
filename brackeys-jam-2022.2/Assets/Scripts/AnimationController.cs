using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {
    public Animator PlayerLegsAnimator;
    public Animator PlayerTorsoAnimator;
    public PlayerMovement playerMovement;
    
    public GameObject legs;
    public GameObject torso;

    public bool lastDirectionVertical;
    public string facing;

    private void Update() {
        UpdateLegsAnimation();
        GetFacing();
        UpdateTorsoAnimation();
    }

    public void UpdateLegsAnimation() {
        // up/down
        if (playerMovement.movement.y != 0) {
            PlayerLegsAnimator.Play("Walk-Front-Back");
            lastDirectionVertical = true;
        } else if (playerMovement.movement.x > 0) { //right
            legs.transform.localRotation = Quaternion.Euler(0, 0, 0);
            PlayerLegsAnimator.Play("Walk-Side");
            lastDirectionVertical = false;
        } else if(playerMovement.movement.x < 0) { //left
            legs.transform.localRotation = Quaternion.Euler(0, 180, 0);
            PlayerLegsAnimator.Play("Walk-Side");
            lastDirectionVertical = false;
        }
        
        //idle
        if (playerMovement.movement.x == 0 && playerMovement.movement.y == 0) {
            if(lastDirectionVertical)
                PlayerLegsAnimator.Play("Idle-Front-Back");
            else 
                PlayerLegsAnimator.Play("Idle-Side");
        }
    }

    public void UpdateTorsoAnimation() {
        if(facing == "right") {
            torso.transform.localRotation = Quaternion.Euler(0, 0, 0);
            PlayerTorsoAnimator.Play("Side");
        } else if(facing == "left") {
            torso.transform.localRotation = Quaternion.Euler(0, 180, 0);
            PlayerTorsoAnimator.Play("Side");
        } else if(facing == "up") {
            PlayerTorsoAnimator.Play("Up");
        } else if(facing == "down") {
            PlayerTorsoAnimator.Play("Down");
        }
    }

    public void GetFacing() {
        float y = (playerMovement.mousePos.y - transform.position.y) - 0;
        float x = (playerMovement.mousePos.x - transform.position.x) - 0;

        double facingAngle = (double)Mathf.Atan2(y, x) * (double)(180 / 3.14);
        if(facingAngle > -30 && 30 > facingAngle) {
            facing = "right";
        } else if(facingAngle > 30 && facingAngle < 150) {
            facing = "up";
        } else if(facingAngle > 150 && facingAngle < 180 || facingAngle < -150 && facingAngle > -180) {
            facing = "left";
        } else {
            facing = "down";
        }
    }
}
