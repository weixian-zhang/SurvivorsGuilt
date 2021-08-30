using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    Animator _animator;
    bool isGrounded;
    Transform playerBody;

    public CharacterController charController;

    public float RunSpeed = 1.0f;



    // Start is called before the first frame update
    private void Start()
    {
        _animator = GetComponent<Animator>();

        charController = GetComponent<CharacterController>();
    }

    private void OnCollisionStay(Collision other) {
        isGrounded = true;
    }

    private void OnCollisionExit(){
        isGrounded = false;
    }

    // Update is called once per frame
    private void Update() {

        MoveForwardBackwardLeftRight();

        // if(Input.GetKeyDown (KeyCode.W)) {
        //     _animator.SetBool("isRunning", true);
        //     _animator.SetBool("isIdle", false);
        // }
        // if(Input.GetKeyUp(KeyCode.W)) {
        //     _animator.SetBool("isRunning", false);
        //     _animator.SetBool("isIdle", true);
        // }

        // if(Input.GetKeyDown(KeyCode.Space) && isGrounded){
        //     // _animator.SetBool("isIdle", false);
        //     bool isRunning = _animator.GetBool("isRunning");
        //     if(isRunning) {
        //         _animator.SetBool("isRunningJumping", true);
        //     } else {
        //         _animator.SetBool("isStandingJumping", true);
        //     }
        // }

        // if(!isGrounded) {
        //     _animator.SetBool("isRunningJumping", false);
        //     _animator.SetBool("isStandingJumping", false);
        // }

        //  if(Input.GetKeyUp(KeyCode.Space)) {
        //      _animator.SetBool("isRunningJumping", false);
        //      _animator.SetBool("isStandingJumping", false);
        //      _animator.SetBool("isIdle", true);
        //  }
    }



    private void MoveForwardBackwardLeftRight() {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 move =  transform.right * h + transform.forward * v;

        charController.Move(move * RunSpeed * Time.deltaTime);
    }

}
