using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
    private void OnCollisionEnter(Collision collision)
        
    {
        if (collision.transform.tag == "Obsticle")
        {
            collision.transform.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
            transform.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
        }
    }

}
