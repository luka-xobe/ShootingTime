using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;
    public float ReloadTime = 2f;
    private float ReloadTimeSec = 0f;

    public int maxAmmo = 5;
    private int currentAmmo;
    public float reloadTime = 2.5f;
    private bool isReloading = false;

    public Camera fpsCam;
    public ParticleSystem GunShot_Smoke_FX;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        currentAmmo = maxAmmo;
    }

    // Update is called once per frame
    void Update()
    {

        if (isReloading)
            return;

        if (currentAmmo <= 0)
        {
            StartCoroutine(Reload());
            Reload();
            return;
        }

        if (Input.GetButtonDown("Fire1") && ReloadTime < ReloadTimeSec)
        {
            Shoot();
            ReloadTimeSec = 0;
        }

        ReloadTimeSec += Time.deltaTime;

        
    }


    IEnumerator Reload()
    {
        isReloading = true;
        Debug.Log("Reloading...");

        animator.SetBool("Reloading", true);

        yield return new WaitForSeconds(reloadTime - .25f);

        animator.SetBool("Reloading", false);

        yield return new WaitForSeconds(.25f);


        //ADD SOUND OF LONG RELOADING

        currentAmmo = maxAmmo;
        isReloading = false;

      
    }

        

    void Shoot()
    {
        //animator.SetBool("Shoot", true);

        currentAmmo--;


        FindObjectOfType<AudioManager>().Play("Gunshot");
        GunShot_Smoke_FX.Play();
        //animator.SetBool("Shoot", false);
        FindObjectOfType<AudioManager>().Play("Handgun reload");
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
