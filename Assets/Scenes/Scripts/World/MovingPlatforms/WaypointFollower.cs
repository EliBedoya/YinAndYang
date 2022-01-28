using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    //Array in case I need several waypoints
    [SerializeField] private GameObject[] waypoints;
    private int currentWaypointIndex = 0;
    bool collision = false;

    [SerializeField] private float speed = 0.5f;
        
    private void Update()
    {
        if(collision == true)
        {
        if(Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < .1f)
        {
            if(currentWaypointIndex <= waypoints.Length)
            {
                currentWaypointIndex++;
            }

            if(currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);
        }

    }

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Player")
        {
            Debug.Log ("colisioné");
            collision = true;
            
        }
    }
}
