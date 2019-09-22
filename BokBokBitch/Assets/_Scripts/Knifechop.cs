using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knifechop : MonoBehaviour
{
    public float Rotknife;
    public float yrot;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        transform.localEulerAngles = new Vector3(Mathf.PingPong(Time.time * 100, Rotknife),yrot,(gameObject.transform.localRotation.z));
    }
}
