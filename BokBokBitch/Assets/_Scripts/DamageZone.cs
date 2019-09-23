using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageZone : MonoBehaviour
{
    //private Scene scene;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    scene = SceneManager.GetActiveScene();
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Death");
            SceneManager.LoadScene(1);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("death");
            SceneManager.LoadScene(1);
        }
    }
}
