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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
