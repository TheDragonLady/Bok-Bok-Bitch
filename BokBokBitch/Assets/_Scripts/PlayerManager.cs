using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//[RequireComponent(typeof(CharacterController))]
public class PlayerManager : MonoBehaviour
{ CharacterController characterController;
    public float walkspeed;
    public float Jumpspeed;
    public float gravity;
    public float speed;
    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        characterController = GetComponent<CharacterController>();

    }
    private void Update()
    {
        if (characterController.isGrounded)
        {
            moveDirection = transform.forward * (Input.GetAxis("Vertical"));
            moveDirection += transform.right * (Input.GetAxis("Horizontal"));

            //moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = Jumpspeed;
            }
        }

        moveDirection.y -= gravity * Time.deltaTime;
        characterController.Move(moveDirection * Time.deltaTime);
    }
}
