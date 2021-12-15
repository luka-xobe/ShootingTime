using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InfimaGames.LowPolyShooterPack;

public class gunPickup : MonoBehaviour
{
    // var hasRocketLauncher = false; // tells if you have a rocket launcher
    // var hasMachineGun = false; // tells if you have a machine gun
    //var ammoClips = 1; // tells how many ammo clips you have
    // var rockets = 10; // tells how many rockets you have

    
    GameObject _gameObject;
    [SerializeField] Transform parentObject;
    public bool inTrigger = false;

    void Start()
    {
        _gameObject = this.gameObject;
        inventory = GetComponent<Inventory>();
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            inTrigger = true;
            Debug.Log("In trigger" + inTrigger);
           
        }
        ;
    }
    //GameObject instance1 = Instantiate(_gameObject);
    //points[i] = Instantiate(point,new Vector3 (x,y,0),transform.rotation) as GameObject;
    //public WeaponBehaviour[] weapons;

    Inventory inventory;

    void Update()
    {
        if (inTrigger == true && Input.GetKeyDown("e"))
        {
            Debug.Log("Эта часть кода сработала");
            Instantiate(this.gameObject, parentObject);
            Destroy(this.gameObject);
        }
    }
       
       
}


