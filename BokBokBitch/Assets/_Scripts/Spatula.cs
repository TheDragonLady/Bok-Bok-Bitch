using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spatula : MonoBehaviour
{
    public List<Transform> Waypoints;
    public float speed = 1.0f;
    public int currentDestination = 0;
    public bool forwards;

    // Start is called before the first frame update
    void Start()
    {
        forwards = true;
        transform.position = Waypoints[0].position;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, Waypoints[currentDestination].position, step);

        if (transform.position == Waypoints[currentDestination].position)
        {
            SetNewDestination();
        }



    }

    private void SetNewDestination()
    {
        if (forwards == true)
        {
            currentDestination++;
        }
        
        if (forwards == false)
        {
            currentDestination--;
        }

        if(currentDestination > Waypoints.Count-2)
        {
            forwards = false;
        }

        if(currentDestination == 0)
        {
            forwards = true;
        }

    }

}
