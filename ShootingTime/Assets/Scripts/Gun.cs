using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;
    public float ReloadTime = 3f;
    private float ReloadTimeSec = 0f;

    public Camera fpsCam;
    public ParticleSystem GunShot_Smoke_FX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && ReloadTime < ReloadTimeSec)
        {
            Shoot();
            ReloadTimeSec = 0;
        }

        ReloadTimeSec += Time.deltaTime;
    }

    void Shoot()
    {
        
        GunShot_Smoke_FX.Play();
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }

            
        }

        

    }
}
