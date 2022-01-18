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
        int Velocityhash = 0;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            theNPC.GetComponent<Animator>().SetBool("Idle", true);
        }


        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            theNPC.GetComponent<Animator>().SetBool("Jump", true);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            theNPC.GetComponent<Animator>().SetBool("Move", true);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //Velocityhash = theNPC.GetComponent<Animator>().StringToHash("RFLF");
            theNPC.GetComponent<Animator>().SetFloat(Velocityhash, 0);
        }
    }
}
