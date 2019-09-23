using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frier : MonoBehaviour
{
    public GameObject Player;
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
   /* private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("fhhasjhjsda");
        if (collision.gameObject.tag == "Player")
        {
            gameObject.transform.parent = transform;
           // Debug.Log("fhhasjhjsda");
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObject.transform.parent =null;
        }
    }*/
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ah!!!!");
        if (other.gameObject.tag == "Player")
        {
            gameObject.transform.parent = transform;

        }
    }
}
