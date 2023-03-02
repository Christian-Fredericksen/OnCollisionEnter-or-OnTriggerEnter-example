using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        // if the Player collides with the Obstacle
        // change the color of the Obstacle.

        if (other.transform.tag == "Obstacle")
        {
            other.transform.GetComponent<Renderer>().material.color = Random.ColorHSV();
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Pellet")
        {
            Destroy(other.gameObject);
        }
    }
}
