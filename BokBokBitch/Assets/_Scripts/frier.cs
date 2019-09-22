using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frier : MonoBehaviour
{
    public float timeMultiplyer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localPosition = new Vector3((gameObject.transform.localPosition.x), Mathf.PingPong(Time.time * timeMultiplyer, 1), (gameObject.transform.localPosition.z));
    }
}
