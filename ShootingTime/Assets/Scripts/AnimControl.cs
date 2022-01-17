using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControl : MonoBehaviour
{

    public GameObject theNPC;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            theNPC.GetComponent<Animator>().Play("Idle");
        }


        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            theNPC.GetComponent<Animator>().Play("Jump");
        }
    }
}
