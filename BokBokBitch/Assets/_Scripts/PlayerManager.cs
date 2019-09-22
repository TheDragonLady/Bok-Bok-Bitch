using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class PlayerManager : MonoBehaviour
{
    public float walkspeed;
    private bool limitDiagonalSpeed = true;
    public float Jumpspeed;
    public float grevity;
    public bool Aircontrol = true;
    private Vector3 moveDirection=Vector3.zero;
    private bool grounded = false;
    private CharacterController controller;
    private Transform myTransform;
    private float speed;
    private float slideLimit;
    private RaycastHit hit;
    private float rayDistance;
    private Vector3 contactPoint;
    private int jumpTimer;
    private int AntibunnyhopFactor = 1;
    private bool playerControl = false;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        myTransform = transform;
        speed = walkspeed;
        rayDistance = controller.height * .5f + controller.radius;
        jumpTimer = AntibunnyhopFactor;
     }

    private void FixedUpdate()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        float inputModifyFactor = (inputX != 0.0f && inputY != 0.0f && limitDiagonalSpeed) ? .7071f : 1.0f;

        if (!Input.GetButton("Jump"))
            jumpTimer++;
        else if (jumpTimer >= AntibunnyhopFactor)
        {
            moveDirection.y = Jumpspeed;
            jumpTimer = 0;
        }
        if (Aircontrol&& playerControl)
        {
            moveDirection.x = inputX * speed * inputModifyFactor;
            moveDirection.z = inputY * speed * inputModifyFactor;
            moveDirection = myTransform.TransformDirection(moveDirection);

        }

        moveDirection.y -= grevity * Time.deltaTime;
        grounded = (controller.Move(moveDirection * Time.deltaTime) & CollisionFlags.Below) != 0;

    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        contactPoint = hit.point;
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
