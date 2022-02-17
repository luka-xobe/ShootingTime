using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageFromWeapon : MonoBehaviour
{

    int enemyDamage = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter(Collision col)
    {


        if (col.gameObject.name == "Enemy")
        {
             enemyDamage++;
            Debug.Log("Удар++");
        }
    }
}
