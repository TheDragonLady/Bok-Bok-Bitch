using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Pickups : MonoBehaviour
{

    public int scoreValue;
    private GameObject controller;


    // Start is called before the first frame update
    void Start()
    {
        GameObject controllerObject = GameObject.FindWithTag("Player");
        if(controllerObject != null)
        {
            controller = controllerObject.GetComponent<GameObject>();
        }
        if(controller == null)
        {
            Debug.Log("cannot find player controller script");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Debug.Log("Object Destroyed");
        }
    }
}
