using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAI : MonoBehaviour
{
    private Rigidbody rb;
    //rb = GetComponent<Rigidbody>();


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //guard.GetComponent<Guard>().enabled = true;
           // reset = 5;
            //GetComponent<SphereCollider>().enabled = false;
        }
    }





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
