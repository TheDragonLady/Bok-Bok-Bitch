using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//[RequireComponent(typeof(CharacterController))]
public class PlayerLook : MonoBehaviour
{

    //public variables that can be changed during gameplay
    public float walkspeed;
    public float Jumpspeed;
    public float gravity;
    public float speed;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float s = Input.GetAxis("Horizontal");

        float f = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(s, 0f, f);

        rb.AddForce(movement * speed);
    }
}
