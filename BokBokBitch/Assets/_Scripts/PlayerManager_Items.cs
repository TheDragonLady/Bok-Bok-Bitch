using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerManager_Items : MonoBehaviour
{

    //UI Component to adjust how many pick-ups collected
    public Text countText;
    //UI Component to tell the player they have collected all pick-Ups
    public Text itemText;

    //Integer to store the current amount of pickups
    private int count;


    // Start is called before the first frame update
    void Start()
    {
        count = 0;

        itemText.text = "";

        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;

            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

        if(count >= 6)
        {
            itemText.text = "All PickUps Collected";
        }
    }
}
