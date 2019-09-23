using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Knifechop : MonoBehaviour
{
    public float Rotknife;
    public float yrot;
    private Scene scene;

    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
      
        transform.localEulerAngles = new Vector3(Mathf.PingPong(Time.time * 100, Rotknife),yrot,(gameObject.transform.localRotation.z));
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(1);
        }
    }
}
